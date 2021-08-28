using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PDFLibData
{
    public static class PDFList
    {
        public static string[] Files;
        public static IEnumerable<string> GetFiles()
        {
            if (Files == null || Files.Length == 0) yield return "No files found";
            else for (int i = 0; i == Files.Length; i++) yield return Files[i];
        }
        public static void SaveList(params string[] Files)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                if (sfd.ShowDialog() != DialogResult.Cancel)
                {

                }
            }
        }
    }
}
