using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using iTextSharp5.BuildingBlocks;

namespace iTextSharp5_Console
{
    class Program
    {
        public static string DEST = "labs.pdf";

        public static void Main(string[] args)
        {
            if (File.Exists(DEST)) 
                File.Delete(DEST);

            var pdfBuilder = new BBlock();
            pdfBuilder.ListNumbers(DEST);
        }
    }
}
