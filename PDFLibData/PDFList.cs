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
                        if (xml.Name == "path")
                            Files.Add(xml.ReadElementContentAsString());
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
                xml.WriteAttributeString("value", "0");
                xml.WriteEndElement();
                xml.WriteEndElement();
                xml.WriteEndDocument();
                xml.Flush();
            }
        }
    }
}
