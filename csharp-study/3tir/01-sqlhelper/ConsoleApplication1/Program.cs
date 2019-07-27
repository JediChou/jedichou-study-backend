using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var connStr = ConfigurationManager.ConnectionStrings["Jedi"].ConnectionString;
            // Console.WriteLine(connStr);

            var sql = "select * from tbl_user where name=@name and age=@age";
            var parameters = new SqlParameter[] {
                new SqlParameter("@name", "Jedi"),
                new SqlParameter("@name", 27)
            };

            using (var conn = new SqlConnection(connStr))
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddRange(parameters);
                Console.WriteLine(cmd.CommandText.ToString());
            }
        }
    }
}
