using System;
using System.Windows.Forms;
using PDFLibData;
using iText.Kernel.Pdf;

namespace PDFLibReader
{
    public partial class PDFReader : Form
    {
        public static string current = "";
        public PDFReader()
        {
            InitializeComponent();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (Array.IndexOf(PDFList.Files, current) == PDFList.Files.Length - 1)
            {
                MessageBox.Show("Limit has been reached, returning to first PDF of provided list.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                current = PDFList.Files[0];
            }
            else current = PDFList.Files[Array.IndexOf(PDFList.Files, current) + 1];
            PdfReader reader = new PdfReader(current);
        }
    }
}
