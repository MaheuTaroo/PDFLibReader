using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using PDFLibData;
namespace PDFLibReader
{
    static class Program
    {
        public static bool read = false;
        public static string library = "", path = Environment.ExpandEnvironmentVariables(@"%APPDATA%\..\Local\PDFLibReader\FileHist");
        public static Stack<string> history = new Stack<string>(0), newHistory = new Stack<string>(0);
        // TODO
        // Better implementation of file history
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (File.Exists(path))
            {
                Stack<string> temp = new Stack<string>();
                using (FileStream fileStream = new FileStream(path, FileMode.Open))
                using (StreamReader reader = new StreamReader(fileStream))
                    foreach (string s in reader.ReadToEnd().Split(new string[1] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries))
                        temp.Push(s);
                while (temp.Count != 0)
                    history.Push(temp.Pop());
            }

            while (true)
            {
                switch (args.Length)
                {
                    case 0:
                        Application.Run(new Start());
                        break;

                    case 1:
                        if (args[0].ToLower().EndsWith(".plrd") || args[0].ToLower().EndsWith(".pdf")) Application.Run(new PDFReader(args[0]));
                        else MessageBox.Show("The given file is neither a PDFLibReader library nor a PDF file. Please give a file with the .plrd or .pdf extension, so PDFLibReader can process correctly the file and enter reading mode.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                        break;

                    default:
                        foreach (string file in args)
                        {
                            //PDFList.Files.Add(file);
                            // TODO
                            // Continue pdf + plrd support
                            switch (file.Substring(file.LastIndexOf('.')).ToLower())
                            {
                                case ".pdf":
                                    PDFList.Files.Add(file);
                                    break;

                                case ".plrd":
                                    using (XmlReader reader = XmlReader.Create(file)) 
                                        while (reader.Read())
                                            if (reader.Name == "path") 
                                                PDFList.Files.Add(reader.ReadElementContentAsString());
                                    break;

                                default:
                                    MessageBox.Show("At least one of the given files does not correspond to a PDF file or a PDFLibReader library. Please make sure all the files' extensions are \".pdf\" or \".plrd\"", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    Application.Exit();
                                    break;
                            }
                        }
                        Application.Run(new NewPDFLib(PDFList.Files));
                        break;
                }
                if (read) Application.Run(PDFList.Files != null ? new PDFReader() : new PDFReader(library));
                else break;
                args = new string[0];
            }
            if (newHistory.Count != 0)
                using (StreamWriter writer = new StreamWriter(path, true))
                    writer.Write(newHistory.ToArray().Join());
        }
    }
}