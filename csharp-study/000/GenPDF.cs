using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace GenPDF
{
    class Program
    {
        static void Main(string[] args)
        {
            MyPdf pdfme = new MyPdf("Y:\\abc.pdf");
            Console.ReadKey();
        }
    }

    class MyPdf
    {
        private Document _pdfDocument;
        private BaseFont _bfSun = 
            BaseFont.CreateFont(
                @"c:\windows\fonts\SIMSUN.TTC,1", 
                BaseFont.IDENTITY_H, 
                BaseFont.NOT_EMBEDDED
            );

        public MyPdf(string fileName)
        {
            Font font = new Font(_bfSun, 21, 1);
            _pdfDocument = new Document(PageSize.A4, 10, 10, 25, 25);
            PdfWriter writer = PdfWriter.GetInstance(_pdfDocument, new FileStream(fileName, FileMode.Create));

            _pdfDocument.Open();

            Paragraph Header = new Paragraph("ABC", font);
            Header.Alignment = 1;
            _pdfDocument.Add(Header);

            Paragraph p1 = new Paragraph(@"
                看看漢字是否可以,
                冬天來了，春天還會遠嗎！
                再來一段看看…", font);
            p1.Alignment = 2;
            _pdfDocument.Add(p1);

            _pdfDocument.Close();
        }
    }
}
