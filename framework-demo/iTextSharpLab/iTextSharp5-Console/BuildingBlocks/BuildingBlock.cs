using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace iTextSharp5.BuildingBlocks
{
    /// <summary>
    /// 用於演示iTextSharp5中如何建立Blocks
    /// </summary>
    public partial class BBlock : IBuildingBlock, IBlockList
    {
        /// <summary>
        /// Title: 最簡PDF
        /// </summary>
        public void DefaultGeneratePDF(string file)
        {
            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream(file, FileMode.Create));
            document.Open();
            document.Add(new Paragraph("Hello World"));
            document.NewPage();
            document.Add(new Paragraph("Something is wrong"));
            document.Close();
        }

        /// <summary>
        /// Title: Chapter And Section Examples
        /// Ref: http://developers.itextpdf.com/examples/itext5-building-blocks/chapter-and-section-examples
        /// </summary>
        public void ChapterAndSectionExample(string file)
        {
            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream(file, FileMode.Create));
            document.Open();
            Font chapterFont = FontFactory.GetFont(FontFactory.HELVETICA, 16, Font.BOLDITALIC);
            Font paragraphFont = FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.NORMAL);
            Chunk chunk = new Chunk("This is the title , something will be change 中文中文中文", chapterFont);
            Chapter chapter = new Chapter(new Paragraph(chunk), 1);
            chapter.SetChapterNumber(0);
            chapter.Add(new Paragraph("This is the paragraph", paragraphFont));
            document.Add(chapter);
            document.Close();
        }

        /// <summary>
        /// Title: Chunk Background
        /// Title CN: 文本塊的背景色
        /// Ref: http://developers.itextpdf.com/examples/itext5-building-blocks/chunk-examples
        /// </summary>
        public void ChunkBackground(string file)
        {
            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream(file, FileMode.Create));
            document.Open();
            Font f = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 25.0f, Font.BOLD, BaseColor.WHITE);
            Chunk c = new Chunk("White text on red background", f);
            c.SetBackground(BaseColor.RED);
            Paragraph p = new Paragraph(c);
            document.Add(p);
            document.Close();
        }

        /// <summary>
        /// Title: Sub Super Script
        /// Title CN: TODO
        /// Ref: http://developers.itextpdf.com/examples/itext5-building-blocks/chunk-examples
        /// </summary>
        public void SubSuperScript(string file)
        {
            // TODO: FontFactory如何支持中文? 熊罡的那一版中似乎是擴展了字體部分～
            // TODO: BaseFont.CP1257這個屬性的意義是?

            var document = new Document();
            PdfWriter.GetInstance(document, new FileStream(file, FileMode.Create));
            document.Open();
            BaseFont bf = BaseFont.CreateFont(FontFactory.TIMES_ROMAN, BaseFont.CP1252, BaseFont.EMBEDDED);
            Font f = new Font(bf, 10);
            Paragraph p = new Paragraph("H\u2082SO\u2074", f);
            document.Add(p);
            document.Close();
        }

        /// <summary>
        /// Title: Ordinal Numbers
        /// Title CN: TODO
        /// Ref: http://developers.itextpdf.com/examples/itext5-building-blocks/chunk-examples
        /// </summary>
        public void OrdinalNumbers(string file)
        {
            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream(file, FileMode.Create));
            document.Open();
            BaseFont bf = BaseFont.CreateFont(FontFactory.HELVETICA, BaseFont.CP1252, BaseFont.EMBEDDED);
            Font small = new Font(bf, 6.0f);
            Chunk st = new Chunk("st", small);
            st.SetTextRise(7);
            Chunk nd = new Chunk("nd", small);
            nd.SetTextRise(7);
            Chunk rd = new Chunk("rd", small);
            rd.SetTextRise(7);
            Chunk th = new Chunk("th", small);
            th.SetTextRise(7);
            Paragraph first = new Paragraph();
            first.Add("The 1");
            first.Add(st);
            first.Add(" of May");
            document.Add(first);
            Paragraph second = new Paragraph();
            second.Add("The 2");
            second.Add(nd);
            second.Add(" and the 3");
            second.Add(rd);
            second.Add(" of June");
            document.Add(second);
            Paragraph fourth = new Paragraph();
            fourth.Add("The 4");
            fourth.Add(rd);
            fourth.Add(" of July");
            document.Add(fourth);
            document.Close();
        }

        /// <summary>
        /// Title: Standard Deviation
        /// Title CN: TODO
        /// Ref: http://developers.itextpdf.com/examples/itext5-building-blocks/chunk-examples
        /// </summary>
        /// <param name="file">File path</param>
        public void StandardDeviation(string file)
        {
            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream(file, FileMode.Create));
            document.Open();
            document.Add(new Paragraph("The standard deviation symbol doesn't exist in Helvetica."));
            BaseFont bf = BaseFont.CreateFont(FontFactory.HELVETICA, BaseFont.CP1252, BaseFont.EMBEDDED);
            Font symbol = new Font(bf);
            Paragraph p = new Paragraph("So we use the Symbol font: ");
            p.Add(new Chunk("s", symbol));
            document.Add(p);
            document.Close();
        }

        /// <summary>
        /// Title: Bullets
        /// Title CN: TODO
        /// Ref: http://developers.itextpdf.com/examples/itext5-building-blocks/chunk-examples
        /// </summary>
        /// <param name="file"></param>
        public void Bullets(string file)
        {
            string[] items = new string[] 
            {
                "Insurance system", "Agent", "Agency", "Agent Enrollment", "Agent Settings",
                "Appointment", "Continuing Education", "Hierarchy", "Recruiting", "Contract",
                "Message", "Correspondence", "Licensing", "Party"
            };

            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream(file, FileMode.Create));
            document.Open();
            //Font zapfdingbats = new Font(FontFamily.ZAPFDINGBATS, 8);
            BaseFont bf2 = BaseFont.CreateFont(FontFactory.ZAPFDINGBATS, BaseFont.CP1252, BaseFont.EMBEDDED);
            Font zapfdingbats = new Font(bf2, 8.0f);
            Font font = new Font();
            Chunk bullet = new Chunk("108", zapfdingbats);
 
            Paragraph p = new Paragraph("Items can be split if they don't fit at the end: ", font);
            foreach (string item in items)
	        {
		        p.Add(bullet);
                p.Add(new Phrase(" " + item + " ", font));
	        }
            document.Add(p);
            document.Add(Chunk.NEWLINE);
 
            p = new Paragraph("Items can't be split if they don't fit at the end: ", font);
            foreach (string item in items) 
            {
                p.Add(bullet);
                p.Add(new Phrase("\u00a0" + item.Replace(' ', '\u00a0') + " ", font));
            }
            document.Add(p);
            document.Add(Chunk.NEWLINE);
 
            BaseFont bf = BaseFont.CreateFont("d:/FreeSans.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            Font f = new Font(bf, 12);
            p = new Paragraph("Items can't be split if they don't fit at the end: ", f);
            foreach (string item in items) 
            {
                p.Add(new Phrase("\u2022\u00a0" + item.Replace(' ', '\u00a0') + " ", f));
            }
            document.Add(p);
            document.Close();
        }
    }
}
