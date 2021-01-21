using System;
using System.Collections;

namespace PDFLibData
{
    public static class PDFList
    {
        public static string[] Files { get; set; }

        public static IEnumerable GetFiles()
        {
            for (int i = 0; i < Files.Length; i++) yield return Files[i];
        }
    }
}