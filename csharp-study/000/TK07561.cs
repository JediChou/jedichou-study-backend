using System;
using System.Data.SqlClient;

namespace TK70561
{
	class Program
	{
		static void Main(string[] args)
		{
			// configure and open database connection here
			var theConnection = new SqlConnection();

			theConnection.ConnectionString = "Data Source=localhost; Initial Catalog=JediLab;User Id=sa;Password=zxcvbnm,123456789";

			theConnection.Open();
			if(theConnection.State == System.Data.ConnectionState.Open)
			{
				Console.WriteLine("Database Connection is Open");
				Console.WriteLine(theConnection.ServerVersion);
			}
		}
	}
}
