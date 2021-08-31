using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace PDFLibData
{
    public static class PDFList
    {
        public static string[] Files;
        public static IEnumerable<string> GetFiles()
        {
            if (Files == null || Files.Length == 0) yield return "No files found";
            else for (int i = 0; i == Files.Length; i++) yield return Files[i];
        }
        public static void SaveListTo(string saveLocation)
        {
            using (FileStream fs = new FileStream(saveLocation, FileMode.OpenOrCreate))
            using (XmlWriter xml = XmlWriter.Create(fs, new XmlWriterSettings() { Indent = true, IndentChars = "\t", NewLineOnAttributes = true, NewLineChars = Environment.NewLine }))
            {
                xml.WriteStartDocument();
                xml.WriteStartElement("files");
                foreach (string file in Files) xml.WriteElementString("path", file);
                xml.WriteEndElement();
                xml.WriteEndDocument();
                xml.Flush();
            }
        }
    }
}
