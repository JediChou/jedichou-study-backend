using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NPOI.HSSF.UserModel;

namespace SRept_cmd.BLL
{
    public class ProcessSet
    {
        private List<List<string>> _all;
        private List<string> _firstline;

        /// <summary>
        /// default construct
        /// </summary>
        /// <param name="path">excel path</param>
        public ProcessSet(string path)
        {
            _all = common.ExcelHelper.ReadAllLine(path);
            _firstline = common.ExcelHelper.ReadFirstLine(path);
        }

        /// <summary>
        /// get a workbook, and data resouce by _all field
        /// </summary>
        /// <returns>workbook object</returns>
        public HSSFWorkbook GetHSSFWorkbook()
        {
            return common.ExcelHelper.GenerateWorkbook(_all);
        }
    }
}
