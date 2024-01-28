using System;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Collections.Generic;

namespace PDFLibReader
{
    public partial class NewPDFLib : Form
    {
        static string saveLocation;
        public NewPDFLib() => InitializeComponent();
        public NewPDFLib(List<string> files)
        {
            InitializeComponent();
            if (!(files.Count == 0 || files == null))
            {
                label1.Text = "Edit an existing PDF library";
                Text = "Edit existing library";
                int count = 0;
                foreach (string file in files)
                {
                    if (File.Exists(file)) lbFiles.Items.Add(file);
                    else count++;
                }
                if (count > 0) MessageBox.Show($"{count} of the {files.Count} given files did not exist, so they were not added. The remaining were added to the list of files to save on the library.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnAddFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Multiselect = true,
                Filter = "PDF files|*.pdf",
                InitialDirectory = "%HOMEPATH%\\Desktop"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                int repeatedFiles = 0;
                foreach (string file in ofd.FileNames)
                {
                    if (lbFiles.Items.Contains(file)) repeatedFiles++;
                    else lbFiles.Items.Add(file);
                }
                if (repeatedFiles > 0)
                {
                    if (repeatedFiles == ofd.FileNames.Length) MessageBox.Show("All submitted files have been submitted before; the list has not been altered.", "No files added", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else if (repeatedFiles < ofd.FileNames.Length) MessageBox.Show($"{repeatedFiles} of the {ofd.FileNames.Length} files have been submitted before, so they have not been added to the list.", "Repeated files found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls) c.Enabled = false;
            label2.Text = "Creating new library file...";
            // Checks for empty content selection and library file location
            if (lbFiles.Items.Count == 0) MessageBox.Show("No files have been submitted for library fle creation. Please submit at least one PDF file, or select a .plrd file to read its contents to the new file.", "No files selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (string.IsNullOrEmpty(saveLocation))
            {
                MessageBox.Show("No save location was specified. Please click the \"Save to...\" button to specify a location for the file library.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                label2.Text = string.Empty;
                foreach (Control c in Controls) c.Enabled = true;
            }
            else
            {
                foreach (object file in lbFiles.Items) PDFList.Files.Add(file.ToString());
                PDFList.SaveListTo(saveLocation);
                Program.read = true;
                Program.library = saveLocation;
                Close();
            }
        }
        private void btnSaveTo_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog()
            {
                InitialDirectory = "C:\\Users\\%USERNAME%\\Desktop",
                Filter = "PDFLibReader file|*.plrd",
                RestoreDirectory = true
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // If user submits a file, record its name and location and validate location
                saveLocation = sfd.FileName;
                lblSaved.Text = "Location validated!";
            }
        }
        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            // Checks if there's a selected file, and if its index in the list isn't the first one
            if (lbFiles.SelectedIndex > 0)
            {
                int index = lbFiles.SelectedIndex; // Gets the file's index in the list
                string fileToMove = lbFiles.Items[index].ToString(), fileAbove = lbFiles.Items[index - 1].ToString();
                /* The following list describes each variable's objective:
                 * 
                 * fileAbove - stores the file above the one to move in the list;
                 * fileToMove - stores the file to move down
                 */

                lbFiles.Items[index - 1] = fileToMove;
                lbFiles.Items[index] = fileAbove;
                // These two lines change the files' positions; the file to be moved is now a position up

                lbFiles.SelectedIndex--;
                // Forces the list to select the file that was once to be moved, now a position above
            }
        }
        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            // Checks if there's a selected file, and if its index in the list isn't the last one
            if (lbFiles.SelectedIndex > -1 && lbFiles.SelectedIndex < lbFiles.Items.Count - 1)
            {
                int index = lbFiles.SelectedIndex; // Gets the file's index in the list
                string fileToMove = lbFiles.Items[index].ToString(), fileBelow = lbFiles.Items[index + 1].ToString();
                /* The following list describes each variable's objective:
                 * 
                 * fileBelow - stores the file below the one to move in the list;
                 * fileToMove - stores the file to move down
                 */
                 
                lbFiles.Items[index + 1] = fileToMove;
                lbFiles.Items[index] = fileBelow;
                // These two lines change the files' positions; the file to be moved is now a position down

                lbFiles.SelectedIndex++;
                // Forces the list to select the file that was once to be moved, now a position below
            }
        }
        private void btnRemoveFile_Click(object sender, EventArgs e)
        {
            if (lbFiles.SelectedIndex > -1) // Checks if there is a selected item, checking if SelectedIndex has a non-negative value
                lbFiles.Items.RemoveAt(lbFiles.SelectedIndex); //  Removes the selected file, if valid
        }
    }
}
