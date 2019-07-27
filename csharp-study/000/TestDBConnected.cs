using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

public static class DB
{
	/// <summary>
    /// 連接字符串
    /// </summary>
    public static string DBConnectStr = "Data Source=10.132.160.242,3000; User ID= legal; Password = lEgal*321;persist security info=False;initial catalog=MyLBPE;";

    /// <summary>
    /// 測試數據庫連接
    /// </summary>
    /// <returns></returns>
        public static bool TestConnect()
        {
            using (var conn = new SqlConnection(DBConnectStr))
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                    return true;
                return false;
            }
        }
}

public class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine(DB.TestConnect());
	}
}