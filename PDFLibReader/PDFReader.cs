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
        public PDFReader()
        {
            InitializeComponent();
            lblReaderProp.Text = lblReaderProp.Text.Replace("{FileCount}", PDFList.Files.Count.ToString()).Replace("{Index}", (index + 1).ToString());
            current = PDFList.Files[index];
            pdfViewer1.Document = PdfDocument.Load(current);
            pdfViewer1.Update();
        }
        public PDFReader(string fileLocation, bool isLibrary)
        {
            if (!PDFList.ReadFrom(fileLocation))
            {
                MessageBox.Show("No valid library file was passed, or file doesn't exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            current = PDFList.Files[index];
            pdfViewer1.Document = PdfDocument.Load(current);
            pdfViewer1.Update();
        }
        private void NavigateDocuments(object sender, EventArgs e)
        {
            if ((sender as Button).Name == "btnNext")
            {
                if (PDFList.Files.IndexOf(current) == PDFList.Files.Count - 1)
                {
                    MessageBox.Show("Arrived to last document, navigating to the 1st one.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    current = PDFList.Files[0];
                    index = 0;
                }
                else
                {
                    current = PDFList.Files[PDFList.Files.IndexOf(current) + 1];
                    index++;
                }
            }
            else
            {
                if (PDFList.Files.IndexOf(current) == 0)
                {
                    MessageBox.Show("Arrived to 1sr document, navigating to the last one.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    current = PDFList.Files[PDFList.Files.Count - 1];
                    index = PDFList.Files.Count - 1;
                }
                else
                {
                    current = PDFList.Files[PDFList.Files.IndexOf(current) - 1];
                    index--;
                }
            }
            pdfViewer1.Document = PdfDocument.Load(current);
            pdfViewer1.Update();
            lblReaderProp.Text = $"File {index + 1} of {PDFList.Files.Count}";
        }
        private void PDFReader_FormClosing(object sender, FormClosingEventArgs e) => Program.read = false;
    }
}
