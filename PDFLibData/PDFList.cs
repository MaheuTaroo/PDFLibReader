using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
