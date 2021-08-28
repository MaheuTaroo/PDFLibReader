using System;
using System.Windows.Forms;
using System.Xml;
using PDFLibData;
namespace PDFLibReader
{
    public partial class NewPDFLib : Form
    {
        static string saveLocation;
        public NewPDFLib() => InitializeComponent();
        private void btnAddFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Multiselect = true,
                Filter = "PDF files|*.pdf"
            };
            if (ofd.ShowDialog() == DialogResult.OK) lbFiles.Items.AddRange(ofd.FileNames);
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls) c.Enabled = false;
            label2.Text = "Creating new library file...";
            if (string.IsNullOrEmpty(saveLocation)) MessageBox.Show("No save location was specified. Please click the \"Save to...\" button to specify a location for the file library.");
            else
            {
                using (XmlWriter xml = XmlWriter.Create(saveLocation, new XmlWriterSettings() { Indent = true, IndentChars = "\t", NewLineOnAttributes = true, NewLineChars = Environment.NewLine}))
                {
                    xml.WriteStartDocument();
                    xml.WriteStartElement("files");
                    foreach (string file in lbFiles.Items) xml.WriteElementString("path", file);
                    xml.WriteEndElement();
                    xml.WriteEndDocument();
                    xml.Flush();
                    xml.Close();
                }
                PDFList.Files = new string[lbFiles.Items.Count];
                lbFiles.Items.CopyTo(PDFList.Files, 0);
                Program.read = true;
                Close();
            }
        }
        private void btnSaveTo_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "PDFLibReader file|*.plrd"
            };
            if (sfd.ShowDialog() == DialogResult.OK) saveLocation = sfd.FileName;
            lblSaved.Text = "Location validated!";
        }
    }
}
