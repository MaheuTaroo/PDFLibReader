using System;
using System.Windows.Forms;

namespace PDFLibReader
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
            if (Program.history.Count != 0)
                lbFileHist.Items.AddRange(Program.history.ProcessForHistoryBox());
        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() != DialogResult.Cancel && !string.IsNullOrEmpty(ofd.FileName))
            {
                switch (ofd.FileName.Substring(ofd.FileName.LastIndexOf('.')))
                {
                    case ".plrd":
                        if (Program.read = PDFList.NewList(ofd.FileName))
                            Program.library = ofd.FileName;
                        else
                            MessageBox.Show("There was an error processing the given file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Close();
                        break;

                    case ".pdf":
                        PDFList.Files.Clear();
                        PDFList.Files.Add(ofd.FileName);
                        Program.read = true;
                        Close();
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
                    Multiselect = false,
                    Filter = "PDFLibReader library|*.plrd",
                    InitialDirectory = Environment.ExpandEnvironmentVariables("%HOMEPATH%\\Desktop")
                })
                    if (ofd.ShowDialog() == DialogResult.OK)
                        new NewPDFLib(PDFList.ReadLib(ofd.FileName, out _)).ShowDialog();
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