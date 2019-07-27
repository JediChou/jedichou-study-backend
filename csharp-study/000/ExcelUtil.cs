using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.IO;
using NPOI.SS.UserModel;
using NPOI.HSSF.UserModel;

namespace CustomsReportApp
{
    public class ExcelUtil
    {        
        public DataSet ExcelToDS(string Path)
        {
            string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + Path + ";" + "Extended Properties='Excel 8.0;IMEX=1'";
            OleDbConnection conn = new OleDbConnection(strConn);
            string strExcel = "";
            OleDbDataAdapter myCommand = null;
            DataSet ds = null;
            try
            {
                conn.Open();
                strExcel = "select * from [Sheet1$]";
                myCommand = new OleDbDataAdapter(strExcel, strConn);
                ds = new DataSet();
                myCommand.Fill(ds);
                conn.Close();

                return ds;
            }
            catch
            {
                try
                {
                    strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path + ";Excel 12.0 Xml;HDR=YES;";
                    conn = new OleDbConnection(strConn);
                    conn.Open();
                    strExcel = "select * from [Sheet1$]";
                    myCommand = new OleDbDataAdapter(strExcel, strConn);
                    ds = new DataSet();
                    myCommand.Fill(ds);
                    conn.Close();

                    return ds;
                }
                catch
                {
                    return null;
                }
            }
        }

        public string Export(System.Data.DataTable dt, string aimFile)
        {
            try
            {
                //string destFileName = System.Windows.Forms.Application.StartupPath + "\\CustomsTemplate.xls";
                //FileStream file = new FileStream(destFileName, FileMode.Open, FileAccess.Read);
                //IWorkbook hssfworkbook = new HSSFWorkbook(file);
                //ISheet sheet1 = hssfworkbook.GetSheet("Sheet1");

                if (dt.Columns.Contains("原单号"))
                {
                    dt.Columns.Remove("原单号");
                }

                HSSFWorkbook workbook = new HSSFWorkbook();
                var sheet = workbook.CreateSheet();

                //填充表头
                var headRow = sheet.CreateRow(0);
                foreach (DataColumn column in dt.Columns)
                {
                    headRow.CreateCell(column.Ordinal).SetCellValue(column.ColumnName);
                }

                //------------------------
               // int curRowNum=sheet1.FirstRowNum+1;               
               //var row = sheet1.GetRow(curRowNum);
               //row.CopyRowTo(curRowNum + 1);
               ////row.Cells.AddRange( 
               //row.CreateCell(0).SetCellValue("");
                 
               int rowIndex = 1;
               foreach (DataRow row in dt.Rows)
               {
                   var dataRow = sheet.CreateRow(rowIndex);
                   foreach (DataColumn column in dt.Columns)
                       dataRow.CreateCell(column.Ordinal).SetCellValue(row[column].ToString());
                   ++rowIndex;
               }
                //------------------------  
                //保存
                using (FileStream fs = new FileStream(aimFile, FileMode.Create, FileAccess.Write))
                {
                    workbook.Write(fs);
                } 

                return "OK";            
            }
            catch (Exception ex)
            {
                string errMsg = ex.Message;
                Util.SaveLog("Log Error: --- 生成报关单失败 --- " + errMsg, true);
                return "失败--" + errMsg;
            } 
        }
    }
}
