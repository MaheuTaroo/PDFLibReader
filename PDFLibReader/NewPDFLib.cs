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
        public NewPDFLib(string[] files)
        {
            InitializeComponent();
            if (files.Length == 0 || files == null) MessageBox.Show("No files were given; application will enter in library creaton mode.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                label1.Text = "Edit an existing PDF library";
                Text = "Edit existing library";
            }
        }
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
            if (string.IsNullOrEmpty(saveLocation))
            {
                MessageBox.Show("No save location was specified. Please click the \"Save to...\" button to specify a location for the file library.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                label2.Text = string.Empty;
                foreach (Control c in Controls) c.Enabled = true;
            }
            else
            {
                PDFList.Files = new string[lbFiles.Items.Count];
                lbFiles.Items.CopyTo(PDFList.Files, 0);
                PDFList.SaveListTo(saveLocation);
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
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                saveLocation = sfd.FileName;
                lblSaved.Text = "Location validated!";
            }
        }
    }
}
