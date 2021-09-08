using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            if (args.Length == 0)
            {
                Application.Run(new Start());
                if (read) Application.Run(new PDFReader(library));
            }
            else if (!args[0].EndsWith(".plrd")) MessageBox.Show("The given file is not a PDFLibReader library. Please give a file with the .plrd extension, so PDFLibReader can process correctly the file and enter reading mode", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else Application.Run(new PDFReader(args[0]));
        }
    }
}