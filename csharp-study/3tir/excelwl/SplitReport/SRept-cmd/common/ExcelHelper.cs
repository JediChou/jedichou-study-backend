using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using NPOI.HSSF.UserModel;

namespace SRept_cmd.common
{
    public static class ExcelHelper
    {
        /// <summary>
        /// read first line of excel file
        /// </summary>
        /// <param name="path">excel file path</param>
        /// <returns>first line string list</returns>
        public static List<string> ReadFirstLine(string path)
        {
            // check file exists
            if (!File.Exists(path))
                return null;

            // define result
            var result = new List<string>();

            // using npoi to read first line of excel first sheet
            using (var fsr = File.OpenRead(path))
            {
                var workbook = new HSSFWorkbook(fsr);
                if (workbook.NumberOfSheets != 0)
                {
                    var sheet = workbook.GetSheetAt(0);
                    if (sheet.LastRowNum != 0)
                    {
                        var row = sheet.GetRow(0);
                        for (int col = 0; col < row.LastCellNum; col++)
                        {
                            var cell = row.GetCell(col);
                            result.Add(cell.ToString().Trim()); // 前后空格去掉
                        }
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }

            // return result
            return result;
        }

        /// <summary>
        /// read all line of excel file
        /// </summary>
        /// <param name="path">excel file path</param>
        /// <returns>a list of string list</returns>
        public static List<List<string>> ReadAllLine(string path)
        {
            // check file exists
            if (!File.Exists(path))
                return null;

            // define result
            var result = new List<List<string>>();

            // using npoi to read all lines of excel first sheet
            // create file read object
            using (var fsr = File.OpenRead(path))
            {
                var workbook = new HSSFWorkbook(fsr);

                for (int i = 0; i < workbook.NumberOfSheets; i++)
                {
                    // create a sheet object from workbook. It run at memory
                    var sheet = workbook.GetSheetAt(i);

                    // Iterated row
                    for (int j = 0; j <= sheet.LastRowNum; j++)
                    {
                        // create a row object from sheet object
                        var row = sheet.GetRow(j);
                        var line = new List<string>();

                        // Iterated cell
                        for (int col = 0; col < row.LastCellNum; col++)
                        {
                            // Create a cell object from row object.
                            // And output cell content to screen.
                            var cell = row.GetCell(col);
                            line.Add(cell.ToString().Trim());
                        }
                        
                        // save line content to a list<string> object
                        result.Add(line);
                    }
                }
            }

            // return result
            return result;
        }

        /// <summary>
        /// generate a excel workbook by a string sets
        /// </summary>
        /// <param name="sets">workbook datas</param>
        /// <returns></returns>
        public static HSSFWorkbook GenerateWorkbook(List<List<string>> sets)
        {
            var workbook = new HSSFWorkbook();

            if (sets != null)
            {
                for (int i = 0; i < sets[0].Count; i++)
                {
                    try { workbook.CreateSheet(sets[0][i]); 
                    } catch {}
                }

                // fill cell after create row and cell
                for (int k = 0; k < sets[0].Count; k++)
                {
                    var sheet = workbook.GetSheetAt(k);
                    for (int i = 0; i < sets.Count; i++)
                    {
                        var row = sheet.CreateRow(i);
                        var rowContenxt = sets[i];
                        for (int j = 0; j < rowContenxt.Count; j++)
                            row.CreateCell(j, NPOI.SS.UserModel.CellType.STRING).SetCellValue(rowContenxt[j].ToString());
                    }
                }

                return workbook;
            }
            return null;
        }

        /// <summary>
        /// create a excel file by nopi workbook object
        /// </summary>
        /// <param name="workbook">workbook object</param>
        /// <param name="path">excel path</param>
        /// <returns>file created</returns>
        public static bool GenerateExcel(HSSFWorkbook workbook, string path)
        {
            if (File.Exists(path)) File.Delete(path);
            using (var fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                workbook.Write(fs);
            return File.Exists(path);
        }
    }
}
