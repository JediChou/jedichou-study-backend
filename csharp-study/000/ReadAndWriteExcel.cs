using System;
using System.Reflection;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace Test
{
    public class Program
    {
        static void Main(string[] args)
        {
            var ds = Excel.ExcelToDS(@"d:\test2.xls");
            if (ds != null && ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    // Get value by parse
                    var date = DateTime.Parse(row[0].ToString());
                    var name = row[1].ToString();
                    var income = (double)Math.Round(double.Parse(row[2].ToString()));
                    var cost = (double)Math.Round(double.Parse(row[3].ToString()));
                    
                    // process date
                    var year = date.Year;
                    var month = date.Month;
                    var day = date.Day;
                    var time = year.ToString() + "-" + month.ToString() + "-" + day.ToString();
                    Console.WriteLine("{0} {1} {2} {3}", time, name, income, cost);
                }
            }
            Console.ReadLine();
        }
    }

    public static class Excel
    {
        public static DataSet ExcelToDS(string Path)
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
    }
}
