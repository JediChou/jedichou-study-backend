using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPOI;
using NPOI.HSSF.UserModel;
using System.IO;

namespace npoi
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadXLS(@"./info.xls");
        }

        /// <summary>
        /// Demo for read xls
        /// </summary>
        /// <param name="path"></param>
        private static void ReadXLS(string path)
        {
            // create a read file object
            using (var fsr = File.OpenRead(path))
            {
                // create a worksheet object to read xls
                var workbook = new HSSFWorkbook(fsr);

                // read sheet 
                // get number of sheet (worksheet.NumberOfSheets)
                for (int i = 0; i < workbook.NumberOfSheets; i++)
                {
                    var sheet = workbook.GetSheetAt(i);
                    Console.WriteLine("============= {0} =============", sheet.SheetName);

                    for (int j = 0; j <= sheet.LastRowNum; j++)
                    {
                        var row = sheet.GetRow(j);
                        for (int col = 0; col < row.LastCellNum; col++)
                        {
                            var cell = row.GetCell(col);
                            Console.Write("{0}\t", cell.ToString());
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
