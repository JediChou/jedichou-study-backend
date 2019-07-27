using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NPOI.HSSF.UserModel;
using NPOI.HSSF.EventUserModel;
using System.IO;

namespace ExcelImport
{
    /// <summary>
    /// Import datas into Excel file
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string file = @"./info.xls";

            var listStr1 = new List<List<string>>();
            listStr1.Add(new List<string> { "workid", "name", "location" });
            listStr1.Add(new List<string> { "F3216338", "Jedi", "D13-4" });
            listStr1.Add(new List<string> { "F3219815", "Ray", "D13-4" });

            var listStr2 = new List<List<string>>();
            listStr2.Add(new List<string> { "MM131", "Moko", "Beautyleg", "Yuetu" });
            listStr2.Add(new List<string> { "YuCheng", "李乔丹", "Sarah", "AngelaBaby" });
            listStr2.Add(new List<string> { "西施妹", "王思淇", "Zin"});
            listStr2.Add(new List<string> { "虎牙妹", "李丹", "Mokoyo", "Taylor Swfit" });

            // WriteToXls(file);
            WriteToXls(file, listStr1, "测试3");
            WriteToXls(file, listStr2, "测试4");

        }

        /// <summary>
        /// Write data to file
        /// </summary>
        /// <param name="path"></param>
        private static void WriteToXls(string path)
        {
            // If file exists then delete it.
            if (File.Exists(path)) File.Delete(path);

            // Create some execl workbook object and others..
            var workbook = new HSSFWorkbook();
            var sheet = workbook.CreateSheet("Jedi");
            var first_row = sheet.CreateRow(0);
            var second_row = sheet.CreateRow(1);
            first_row.CreateCell(0, NPOI.SS.UserModel.CellType.STRING).SetCellValue("workid");
            first_row.CreateCell(1, NPOI.SS.UserModel.CellType.STRING).SetCellValue("name");
            first_row.CreateCell(2, NPOI.SS.UserModel.CellType.STRING).SetCellValue("location");
            second_row.CreateCell(0, NPOI.SS.UserModel.CellType.STRING).SetCellValue("F3216338");
            second_row.CreateCell(1, NPOI.SS.UserModel.CellType.STRING).SetCellValue("Jedi");
            second_row.CreateCell(2, NPOI.SS.UserModel.CellType.STRING).SetCellValue("D13-4");

            sheet = workbook.CreateSheet("Ray");
            first_row = sheet.CreateRow(0);
            second_row = sheet.CreateRow(1);
            first_row.CreateCell(0, NPOI.SS.UserModel.CellType.STRING).SetCellValue("workid");
            first_row.CreateCell(1, NPOI.SS.UserModel.CellType.STRING).SetCellValue("name");
            first_row.CreateCell(2, NPOI.SS.UserModel.CellType.STRING).SetCellValue("location");
            first_row.CreateCell(3, NPOI.SS.UserModel.CellType.STRING).SetCellValue("floor");
            second_row.CreateCell(0, NPOI.SS.UserModel.CellType.STRING).SetCellValue("F3216338");
            second_row.CreateCell(1, NPOI.SS.UserModel.CellType.STRING).SetCellValue("Jedi");
            second_row.CreateCell(2, NPOI.SS.UserModel.CellType.STRING).SetCellValue("D13-4");
            second_row.CreateCell(3, NPOI.SS.UserModel.CellType.STRING).SetCellValue("4th");

            // Use a FileStream to import data
            using (var fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                workbook.Write(fs);
        }

        /// <summary>
        /// Write list data to xls
        /// </summary>
        /// <param name="listStr"></param>
        /// <param name="path"></param>
        private static void WriteASheetToXls(string filepath, List<List<string>> listStr, string sheetname)
        {
            HSSFWorkbook workbook;

            if (File.Exists(filepath))
            {
                using (var rfs = File.OpenRead(filepath))
                    workbook = new HSSFWorkbook(rfs);

                var sheet = workbook.CreateSheet(sheetname);

                // 创建行
                for (int i = 0; i < listStr.Count; i++)
                {
                    var row = sheet.CreateRow(i);

                    // 创建单元格
                    for (int j = 0; j < listStr[i].Count; j++)
                    {
                        row.CreateCell(j, NPOI.SS.UserModel.CellType.STRING).SetCellValue(listStr[i][j].ToString());
                    }
                }

                using (var wfs = new FileStream(filepath, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))
                    workbook.Write(wfs);
            }
            else
            {
                workbook = new HSSFWorkbook();
                
                var sheet = workbook.CreateSheet(sheetname);

                // 创建行
                for (int i = 0; i < listStr.Count; i++)
                {
                    var row = sheet.CreateRow(i);

                    // 创建单元格
                    for (int j = 0; j < listStr[i].Count; j++)
                    {
                        row.CreateCell(j, NPOI.SS.UserModel.CellType.STRING).SetCellValue(listStr[i][j].ToString());
                    }
                }

                using (var fs = new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                    workbook.Write(fs);
            }
        }
    }
}
