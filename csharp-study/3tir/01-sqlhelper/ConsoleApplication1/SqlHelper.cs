using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace demo
{
    /// <summary>
    /// SqlHelper class
    /// </summary>
    public static class SqlHelper
    {
        /// <summary>
        /// connect string
        /// </summary>
        public static readonly string connStr = ConfigurationManager.ConnectionStrings["local"].ConnectionString;

        /// <summary>
        /// 1. 执行增删改查
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="cmdType">sqlcommand对象</param>
        /// <param name="pms">sqlcommand的参数</param>
        /// <returns>受影响的行数</returns>
        public static int ExecuteNonQuery(string sql, CommandType cmdType, params SqlParameter[] pms)
        {
            using (var conn = new SqlConnection(connStr))
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.CommandType = cmdType;
                if (pms != null) cmd.Parameters.AddRange(pms);
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// 2. 返回单行单列的方法
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="cmdType">sqlcommand对象</param>
        /// <param name="pms">sqlcommand的参数</param>
        /// <returns>查询结果</returns>
        public static object ExecuteScalar(string sql, CommandType cmdType, params SqlParameter[] pms)
        {
            using (var conn = new SqlConnection(connStr))
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.CommandType = cmdType;
                if (pms != null)
                    cmd.Parameters.AddRange(pms);
                conn.Open();
                return cmd.ExecuteScalar();
            }
        }

        /// <summary>
        /// 3. 返回多行多列的方法
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="cmdType">sqlcommand对象</param>
        /// <param name="pms">sqlcommand的参数</param>
        /// <returns>查询结果</returns>
        public static SqlDataReader ExecuteReader(string sql, CommandType cmdType, params SqlParameter[] pms)
        {
            var conn = new SqlConnection(connStr);
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.CommandType = cmdType;
                if (pms != null) cmd.Parameters.AddRange(pms);

                // Jedi: notice
                try
                {
                    conn.Open();
                    return cmd.ExecuteReader(CommandBehavior.CloseConnection); 
                }
                catch
                {
                    conn.Close();
                    conn.Dispose();
                    throw;
                }
            }
        }

        /// <summary>
        /// 4. 返回DataTable
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="cmdType">sqlcommand对象</param>
        /// <param name="pms">sqlcommand的参数</param>
        /// <returns>DataTable对象</returns>
        public static DataTable ExecuteDataTable(string sql, CommandType cmdType, params SqlParameter[] pms)
        {
            var dt = new DataTable();
            using (var adapter = new SqlDataAdapter(sql, connStr))
            {
                adapter.SelectCommand.CommandType = cmdType;
                if (pms != null) adapter.SelectCommand.Parameters.AddRange(pms);
                adapter.Fill(dt);
                return dt;
            }
        }
    }
}
