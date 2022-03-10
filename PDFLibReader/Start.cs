using System;
using System.Linq;
using PDFLibData;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;
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
                if (ofd.FileName.EndsWith(".plrd"))
                {
                    PDFList.Files = new List<string>();
                    using (XmlReader reader = XmlReader.Create(ofd.FileName)) 
                        while (reader.Read()) 
                            if (reader.Name == "path") 
                                PDFList.Files.Add(reader.ReadElementContentAsString());
                    string pdfs = "";
                    foreach (string pdf in PDFList.GetFiles()) pdfs += pdf + Environment.NewLine;
                    Program.read = true;
                    Close();
                }
                else MessageBox.Show("The provided file's extension is not supported by this application. Please provide a file with the .plrd extension.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ListManipulation(object sender, EventArgs e)
        {
            if ((sender as Button).Text == "Edit")
            {
                using (OpenFileDialog ofd = new OpenFileDialog()
                {
                    Multiselect = true,
                    Filter = "PDF files|*.pdf",
                    InitialDirectory = "%HOMEPATH%\\Desktop",
                    RestoreDirectory = true
                })
                    if (ofd.ShowDialog() == DialogResult.OK)
                        new NewPDFLib(ofd.FileNames.ToList(), true).ShowDialog();
            }
            else new NewPDFLib((new string[0]).ToList(), false).ShowDialog();
            if (Program.read) Close();
        }
    }
}