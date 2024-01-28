using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Linq;

namespace PDFLibReader
{
    public static class PDFList
    {
        private static List<string> _files;
        public static List<string> Files {  
            get
            {
                if (_files == null) _files = new List<string>();
                return _files;
            }
            private set
            {
                _files = value;
            }
        }
        public static int index = 0;
        public static IEnumerable<string> GetFiles()
        {
            if (Files == null || Files.Count == 0) yield return "No files found";
            else for (int i = 0; i < Files.Count; i++) yield return Files[i];
        }
        public static List<string> ReadLib(string libraryLocation, out int index)
        {
            try
            {
                using (FileStream fs = new FileStream(libraryLocation, FileMode.Open))
                using (XmlReader xml = XmlReader.Create(fs))
                {
                    int idx = 0;
                    List<string> files = new List<string>();
                    if (!File.Exists(libraryLocation))
                    {
                        index = 0;
                        return null;
                    }
                    while (xml.Read())
                    {
                        if (xml.Name == "path")
                            files.Add(xml.ReadElementContentAsString());
                        else if (xml.Name == "index")
                            int.TryParse(xml.GetAttribute("value"), out idx);
                    }
                    index = idx;
                    return files;
                }
            }
            catch (Exception)
            {
                index = 0;
                return null;
            }
        }

        public static bool NewList(string libraryLocation)
        {
            Files = libraryLocation.EndsWith(".plrd") ? ReadLib(libraryLocation, out index)
                                                      : new List<string>() { libraryLocation } ;
            return Files != null;
        }

        public static void SaveListTo(string saveLocation)
        {
            using (FileStream fs = new FileStream(saveLocation, FileMode.OpenOrCreate))
            using (XmlWriter xml = XmlWriter.Create(fs, new XmlWriterSettings() { Indent = true, IndentChars = "\t", NewLineOnAttributes = true, NewLineChars = Environment.NewLine }))
            {
                if (fs.Length > 0)
                {
                    fs.SetLength(0);
                    fs.Flush();
                }
                xml.WriteStartDocument();
                xml.WriteStartElement("library");
                xml.WriteStartElement("files");
                foreach (string file in Files) xml.WriteElementString("path", file);
                xml.WriteEndElement();
                xml.WriteStartElement("index");
                xml.WriteAttributeString("value", index.ToString());
                xml.WriteEndElement();
                xml.WriteEndElement();
                xml.WriteEndDocument();
                xml.Flush();
            }
        }
    }
    public static class Utils
    {
        public static string Join(this string[] array) => array.Aggregate((accum, s) => accum += "\n" + s.Trim());
        
        public static string[] ProcessForHistoryBox(this string[] array)
        {
            List<string> temp = new List<string>();
            string manip;
            foreach (string s in array)
                if (File.Exists(s))
                {
                    manip = s.Substring(s.LastIndexOf('\\') + 1) + " (" + s.Substring(0, s.LastIndexOf("\\")) + ')';
                    temp.Add(manip);
                }
            return temp.ToArray();
        }
    }
}
