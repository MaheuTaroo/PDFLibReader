using System;
using System.IO;
using PDFLibData;
using System.Windows.Forms;

namespace PDFLibReader
{
    public partial class Start : Form
    {
        public Start() => InitializeComponent();
        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() != DialogResult.Cancel && !string.IsNullOrEmpty(ofd.FileName))
            {
                if (!ofd.FileName.EndsWith(".plrd"))
                {
                    PDFList.Files = new StreamReader(ofd.FileName).ReadToEnd().Split(Environment.NewLine.ToCharArray());
                    string pdfs = "";
                    foreach (string pdf in PDFList.GetFiles())
                    {
                        pdfs += pdf + Environment.NewLine;
                    }
                    Program.read = true;
                    Close();
                }
                else MessageBox.Show("The provided file's extension is not supported by this application. please provide a file with the .plrd extension.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            new NewPDFLib().ShowDialog();
            if (Program.read) Close();
        }
    }
}
