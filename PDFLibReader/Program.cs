using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using PDFLibData;
namespace PDFLibReader
{
    static class Program
    {
        public static bool read = false;
        public static string library = "";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            /*if (args.Length == 0)
            {
                Application.Run(new Start());
                if (read) Application.Run(new PDFReader(library, true));
            }
            else if (!args[0].EndsWith(".plrd")) MessageBox.Show("The given file is not a PDFLibReader library. Please give a file with the .plrd extension, so PDFLibReader can process correctly the file and enter reading mode", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else Application.Run(new PDFReader(args[0]));*/

            // TODO: Add .pdf support

            /*if (args.Length == 0)
            {
                Application.Run(new Start());
                if (read) Application.Run(new PDFReader(library));
            }
            else if (args.Length == 1)*/
            switch (args.Length)
            {
                case 0:
                    Application.Run(new Start());
                    break;

                case 1:
                    if (args[0].ToLower().EndsWith(".plrd") || args[0].ToLower().EndsWith(".pdf")) Application.Run(new PDFReader(args[0], args[0].EndsWith(".plrd")));
                    else MessageBox.Show("The given file is neither a PDFLibReader library nor a PDF file. Please give a file with the .plrd or .pdf extension, so PDFLibReader can process correctly the file and enter reading mode.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                    break;

                default:
                    PDFList.Files = new List<string>();
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
								{
									while (reader.Read()) if (reader.Name == "path") PDFList.Files.Add(reader.ReadElementContentAsString());
								}
								break;
							
							default:
								MessageBox.Show("At least one of the given files does not correspond to a PDF file or a PDFLibReader library. Please make sure all the files' extensions are \".pdf\" or \".plrd\"", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
								Application.Exit();
								break;
						}
                    }
                    Application.Run(new NewPDFLib(PDFList.Files, false));
                    break;
            }
			if (read) Application.Run(new PDFReader(library, true));
        }
    }
}