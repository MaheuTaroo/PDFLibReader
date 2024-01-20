using System;
using System.Windows.Forms;
using PDFLibData;
using PdfiumViewer;
namespace PDFLibReader
{
    public partial class PDFReader : Form
    {
        public static string current = string.Empty,
                             lib = string.Empty;

        public PDFReader()
        {
            InitializeComponent();
            lblReaderProp.Text = lblReaderProp.Text.Replace("{FileCount}", PDFList.Files.Count.ToString()).Replace("{Index}", (PDFList.index + 1).ToString());
            current = PDFList.Files[PDFList.index];
            pdfRenderer1.Load(PdfDocument.Load(current));
            pdfRenderer1.Update();
        }

        public PDFReader(string fileLocation)
        {
            lib = fileLocation;
            if (!PDFList.ReadFrom(fileLocation))
            {
                MessageBox.Show("No valid library file was passed, or file doesn't exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            InitializeComponent();
            lblReaderProp.Text = lblReaderProp.Text.Replace("{FileCount}", PDFList.Files.Count.ToString()).Replace("{Index}", (PDFList.index + 1).ToString());
            current = PDFList.Files[PDFList.index];
            pdfRenderer1.Load(PdfDocument.Load(current));
            pdfRenderer1.Update();
        }

        private void NavigateDocuments(object sender, EventArgs e)
        {
            if ((sender as Button).Name == "btnNext")
            {
                if (PDFList.Files.IndexOf(current) == PDFList.Files.Count - 1)
                    current = PDFList.Files[PDFList.index = 0];
                else
                    current = PDFList.Files[++PDFList.index];
            }
            else
            {
                if (PDFList.Files.IndexOf(current) == 0)
                    current = PDFList.Files[PDFList.index = PDFList.Files.Count - 1];
                else
                    current = PDFList.Files[--PDFList.index];
            }
            pdfRenderer1.Load(PdfDocument.Load(current));
            pdfRenderer1.Update();
            lblReaderProp.Text = $"File {PDFList.index + 1} of {PDFList.Files.Count}";
        }

        private void PDFReader_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (lib != string.Empty) PDFList.SaveListTo(lib);
            Program.read = false;
        }
    }
}
