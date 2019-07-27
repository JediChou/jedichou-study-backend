using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace iTextSharp5.BuildingBlocks
{
    public partial class BBlock : IBuildingBlock, IBlockList
    {
        /// <summary>
        /// Title: ListAlignment
        /// Title CN: 列表
        /// </summary>
        /// <param name="file">文件路徑</param>
        public void ListAlignment(string file)
        {
            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream(file, FileMode.Create));
            document.Open();
            String text = "test 1 2 3 ";
            for (int i = 0; i < 5; i++)
            {
                text = text + text;
            }
            List list = new List(List.UNORDERED);
            ListItem item = new ListItem(text);
            item.Alignment = Element.ALIGN_JUSTIFIED;
            list.Add(item);
            text = "a b c align ";
            for (int i = 0; i < 5; i++)
            {
                text = text + text;
            }
            item = new ListItem(text);
            item.Alignment = Element.ALIGN_JUSTIFIED;
            list.Add(item);
            text = "supercalifragilisticexpialidocious ";
            for (int i = 0; i < 3; i++)
            {
                text = text + text;
            }
            item = new ListItem(text);
            item.Alignment = Element.ALIGN_JUSTIFIED;
            list.Add(item);
            document.Add(list);
            document.Close();
        }

        /// <summary>
        /// Title: ListNumbers
        /// Title CN: 數字列表
        /// </summary>
        /// <param name="file">文件路徑</param>
        public void ListNumbers(string file)
        {
            var document = new Document();
            PdfWriter.GetInstance(document, new FileStream(file, FileMode.Create));
            document.Open();
            
            // 有縮進的數字序列
            // 定義一個列表，並將其開始值設置為8，然後將其顯示
            document.Add(new Paragraph("Numbered list with automatic indentation"));
            List list1 = new List(List.ORDERED);
            list1.First = 8;
            for (int i = 0; i < 5; i++)
            {
                list1.Add("item");
            }
            document.Add(list1);

            // 無縮進的數字序列
            // 定義一個列表，並將其開始值設置為8，定義是否缩進（這裡指定為false），然後將其顯示
            document.Add(new Paragraph("Numbered list without indentation"));
            List list2 = new List(List.ORDERED);
            list2.First = 8;
            list2.Alignindent = false;
            for (int i = 0; i < 5; i++)
            {
                list2.Add("item");
            }
            document.Add(list2);

            // 內嵌的數字序列
            document.Add(new Paragraph("Nested numbered list"));
            List list3 = new List(List.ORDERED);
            list3.First = 8;
            list3.Alignindent = false;
            list3.PostSymbol = " ";
            for (int i = 0; i < 5; i++)
            {
                list3.Add("item");
                List list = new List(List.ORDERED);
                list.PreSymbol = string.Format("{0}_", 8+i);
                list.PostSymbol = " ";
                list.Add("item 1");
                list.Add("item 2");
                list3.Add(list);
            }
            document.Add(list3);

            document.Close();
        }

        /// <summary>
        /// Title: List With Image As Bullet
        /// </summary>
        /// <param name="file">文件路徑</param>
        public void ListWithImageAsBullet(string file)
        {
            // TODO
        }
    }
}
