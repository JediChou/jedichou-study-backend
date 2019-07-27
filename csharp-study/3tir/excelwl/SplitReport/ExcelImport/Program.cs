using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NPOI.HSSF.UserModel;
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
            WriteToXls(file);
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

            // Use a FileStream to import data
            using (var fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                workbook.Write(fs);
        }
    }
}
