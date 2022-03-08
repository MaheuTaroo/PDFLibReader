using System;
using System.Windows.Forms;
using PDFLibData;
using PdfiumViewer;
using System.IO;
using System.Xml;
namespace PDFLibReader
{
    public partial class PDFReader : Form
    {
        public static string current = "";
        public static int index = 0;
        public PDFReader(string libraryLocation, bool isLibrary)
        {
            InitializeComponent();
            if (!PDFList.ReadFrom(libraryLocation))
            {
                MessageBox.Show("No valid library file was passed, or file doesn't exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            lblReaderProp.Text = lblReaderProp.Text.Replace("{FileCount}", PDFList.Files.Count.ToString()).Replace("{Index}", (index + 1).ToString());
            /*if (File.Exists(libraryLocation) || libraryLocation.EndsWith(".plrd"))
            {
                using (FileStream fs = new FileStream(libraryLocation, FileMode.Open))
                using (XmlReader xml = XmlReader.Create(fs))
                {
                    xml.ReadToFollowing("files");
                    while (xml.Read())
                    {
                        xml.MoveToFirstAttribute();

                    }
                }
            }
            else
            {
                MessageBox.Show("No valid library file was passed, or file doesn't exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }*/
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (PDFList.Files.IndexOf(current) == PDFList.Files.Count - 1)
            {
                MessageBox.Show("Limit has been reached, returning to first PDF of provided list.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                current = PDFList.Files[0];
                index = 0;
            }
            else
            {
                current = PDFList.Files[PDFList.Files.IndexOf(current) + 1];
                index++;
            }
            pdfViewer1.Document = PdfDocument.Load(current);
            pdfViewer1.Update();
        }
        private void PDFReader_FormClosing(object sender, FormClosingEventArgs e)
        {
            // TODO: Add closing logic
        }
    }
}
