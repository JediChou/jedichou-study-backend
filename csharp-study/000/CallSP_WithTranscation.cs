using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

class Program
{
    static void Main(string[] args)
    {
        string connStr =
        @"Data Source=(local);
            User ID= sa;
            Password = samsung1s;
            persist security info=False;
            initial catalog=sqlhelper;";

        // 先创建一个连接
        var conn = new SqlConnection(connStr);
        conn.Open();

        // 定义参数, 事务, 并创建带事务的sqlcommand对象
        var par = new SqlParameter[] { 
            new SqlParameter("@aa", 30),
            new SqlParameter("@bb", 30)
        };
        var trans = conn.BeginTransaction();
        var cmd = new SqlCommand("jedisp", conn, trans);

        try
        {
            // 指定执行类型和参数, 并提交执行事务
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddRange(par);
            int result = (int)cmd.ExecuteScalar();
            trans.Commit();
            conn.Close();
            
            // 打印输出结果
            Console.WriteLine(result);
        }
        catch (SqlException ex)
        {
            // 若有错误则执行事务回滚
            trans.Rollback();
            Console.WriteLine("transcation rollback...");
            Console.WriteLine(ex.Message);
        }
        finally
        {
            // 手工执行清理, 防止连接未释放
            if (cmd != null) cmd = null;
            if (conn != null) { conn.Close(); conn = null; }
            Console.WriteLine("finally execute...");
        }
    }
}