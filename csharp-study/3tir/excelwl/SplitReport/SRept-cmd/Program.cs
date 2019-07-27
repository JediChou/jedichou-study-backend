using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SRept_cmd
{
    class Program
    {
        static void Main(string[] args)
        {
            #region test-read first line and all lines

            //// define variables
            //var excelpath = @"./info.xls";
            //var exceltitle = common.ExcelHelper.ReadFirstLine(excelpath);
            //var excelall = common.ExcelHelper.ReadAllLine(excelpath);
            
            //// read first line
            //foreach (var title in exceltitle)
            //    Console.Write("{0}, ", title);
            //Console.WriteLine();

            //// read all lines
            //foreach (var line in excelall)
            //{
            //    foreach (var cell in line)
            //        Console.Write("{0}, ", cell);
            //    Console.WriteLine();
            //}

            #endregion

            #region test-create a excel file

            var srcfile = @"./info.xls";
            var decfile = @"./info-export.xls";
            var workbook = new BLL.ProcessSet(srcfile).GetHSSFWorkbook();

            if (common.ExcelHelper.GenerateExcel(workbook, decfile))
                Console.WriteLine("Success!");
            else
                Console.WriteLine("Fail!");

            #endregion

        }
    }
}
