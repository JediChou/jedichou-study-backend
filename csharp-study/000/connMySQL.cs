using System;
using System.Data;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace ConnMySQL01
{
	class Program
	{
		public static void Main(string[] args)
		{
			string connStr = "server=localhost;user=root;database=testlogs;port=3306;password=samsung1s;";
			MySqlConnection conn = new MySqlConnection(connStr);
		
			try 
			{
				Console.WriteLine("Connecting to MySQL...");
				conn.Open();

				string sql = "SELECT * FROM testlogs.test";
				MySqlCommand cmd = new MySqlCommand(sql, conn);
				MySqlDataReader rdr = cmd.ExecuteReader();
				
				while (rdr.Read())
					Console.WriteLine(rdr[0]);
				
				rdr.Close();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
			
			conn.Close();
			Console.Write("App done...");
			Console.ReadLine();
		}
	}
}
