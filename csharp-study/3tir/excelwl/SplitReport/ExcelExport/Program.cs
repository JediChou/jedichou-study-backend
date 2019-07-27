using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NPOI.HSSF.UserModel;
using System.IO;

namespace ExcelExport
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadExcel(@"./info.xls");
        }

        /// <summary>
        /// Read data from Excel(2003 format style)
        /// </summary>
        /// <param name="p">File path</param>
        private static void ReadExcel(string path)
        {
            var result = new List<string>();
            var rltfile = "export.txt";

            // create file read object
            using (var fsr = File.OpenRead(path))
            {
                // create a workbook object from fsr, and save it to memory
                var workbook = new HSSFWorkbook(fsr);

                // Iterated sheet
                for (int i = 0; i < workbook.NumberOfSheets; i++)
                {
                    // create a sheet object from workbook. It run at memory
                    var sheet = workbook.GetSheetAt(i);
                    Console.WriteLine("============== {0} ==============", sheet.SheetName);
                    result.Add(string.Format("============== {0} ==============", sheet.SheetName));
                    
                    // Iterated row
                    for (int j = 0; j <= sheet.LastRowNum; j++)
                    {
                        // create a row object from sheet object
                        var row = sheet.GetRow(j);
                        var line_sb = new StringBuilder();

                        // Iterated cell
                        for (int col = 0; col < row.LastCellNum; col++)
                        {
                            // Create a cell object from row object.
                            // And output cell content to screen.
                            var cell = row.GetCell(col);
                            Console.Write("{0} ", cell.ToString());

                            // save cell content to temparoy string builder
                            line_sb.Append(cell.ToString() + " ");
                        }

                        Console.WriteLine();

                        // save line content to a list<string> object
                        result.Add(line_sb.ToString());
                    }
                }
            }

            // Check file exists
            // Export result to text file
            if (File.Exists(rltfile)) File.Delete(rltfile);
            ExportToText(rltfile, result);
        }

        /// <summary>
        /// Write all line to text file
        /// </summary>
        /// <param name="path">File path</param>
        private static void ExportToText(string path, List<string> result)
        {
            using (var fsw = File.CreateText(path))
                foreach (var line in result)
                    fsw.WriteLine(line);
        }
    }
}
