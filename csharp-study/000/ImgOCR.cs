using System;
using System.Collections.Generic;
using System.Text;
using MODI;

namespace ImgOCR
{
    class Program
    {
        static void Main(string[] args)
        {
            MODI.Document md = new MODI.Document();
            md.Create("e:\\testocr.TIF");
            md.OCR(MODI.MiLANGUAGES.miLANG_CHINESE_TRADITIONAL, true, true);

            MODI.Image image = (MODI.Image)md.Images[0];
            MODI.Layout layout = image.Layout;

            MODI.Word word;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < layout.Words.Count; i++)
            {
                word = (MODI.Word)layout.Words[i];
                sb.Append(word.Text);
            }

            Console.WriteLine(sb.ToString());
            Console.ReadLine();
        }
    }
}
