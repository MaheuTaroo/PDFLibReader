using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace PDFLibData
{
    public static class PDFList
    {
        public static List<string> Files;
        public static int index = 0;
        public static IEnumerable<string> GetFiles()
        {
            if (Files == null || Files.Count == 0) yield return "No files found";
            else for (int i = 0; i < Files.Count; i++) yield return Files[i];
        }
        public static bool ReadFrom(string libraryLocation)
        {
            try
            {
                using (FileStream fs = new FileStream(libraryLocation, FileMode.Open))
                using (XmlReader xml = XmlReader.Create(fs))
                    while (xml.Read())
                    {
                        if (Files == null) Files = new List<string>();
                        if (xml.Name == "path")
                            Files.Add(xml.ReadElementContentAsString());
                        else if (xml.Name == "index")
                            index = xml.ReadElementContentAsInt();
                    }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public static void SaveListTo(string saveLocation, bool edit)
        {
            using (FileStream fs = new FileStream(saveLocation, FileMode.OpenOrCreate))
            using (XmlWriter xml = XmlWriter.Create(fs, new XmlWriterSettings() { Indent = true, IndentChars = "\t", NewLineOnAttributes = true, NewLineChars = Environment.NewLine }))
            {
                if (edit)
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
        public static string Join(this string[] array)
        {
            string result = string.Empty;
            for (int i = 0; i < array.Length; i++)
                result += array[i] + (i == array.Length - 1 ? "" : Environment.NewLine);
            return result;
        }
        public static string[] ProcessForHistoryBox(this string[] array)
        {
            List<string> temp = new List<string>();
            string manip = string.Empty;
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
