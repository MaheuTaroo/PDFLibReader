using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using PDFLibData;
namespace PDFLibReader
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
            if (Program.history.Count != 0)
            {
                /*using (FileStream file = new FileStream(Program.path, FileMode.Open))
                using (StreamReader reader = new StreamReader(file))
                    lbFileHist.Items.AddRange(reader.ReadToEnd().Split(new string[1] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries));*/

                lbFileHist.Items.AddRange(Program.history.ToArray().ProcessForHistoryBox());
            }
        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            Console.WriteLine($"{MessageBoxIcon.Error}\r\n{MessageBoxButtons.OK}\r\n{MessageBoxIcon.Asterisk}");
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() != DialogResult.Cancel && !string.IsNullOrEmpty(ofd.FileName))
            {
                switch (ofd.FileName.Substring(ofd.FileName.LastIndexOf('.')))
                {
                    case ".plrd":
                        //PDFList.Files = new List<string>();
                        //using (XmlReader reader = XmlReader.Create(ofd.FileName))
                        //    while (reader.Read())
                        //        if (reader.Name == "path")
                        //            PDFList.Files.Add(reader.ReadElementContentAsString());
                        if (PDFList.ReadFrom(ofd.FileName))
                        {
                            string pdfs = "";
                            foreach (string pdf in PDFList.GetFiles()) pdfs += pdf + Environment.NewLine;
                            Program.read = true;
                        }
                        else
                        {
                            MessageBox.Show("There was an error processing the given file. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Program.read = false;
                        }
                        Close();
                        break;

                    case ".pdf":
                        PDFList.Files = new List<string>();
                        PDFList.Files.Add("");
                        break;

                    default:
                        MessageBox.Show("The provided file's extension is not supported by this application. Please provide a file with the .plrd or .pdf extensions.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
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
                    InitialDirectory = Environment.ExpandEnvironmentVariables("%HOMEPATH%\\Desktop")
                })
                    if (ofd.ShowDialog() == DialogResult.OK)
                        new NewPDFLib(ofd.FileNames.ToList(), true).ShowDialog();
            }
            else new NewPDFLib().ShowDialog();
            if (Program.read) Close();
        }

        private void lbFileHist_MouseClick(object sender, MouseEventArgs e)
        {
            // TODO
            // Complete file selection
            //lbFileHist.SelectedIndex = lbFileHist.IndexFromPoint(e.Location);
        }
    }
}