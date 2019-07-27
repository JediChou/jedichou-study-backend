using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace md5login
{
    /// <summary>
    /// SqlHelper
    /// </summary>
    public static class SqlHelper
    {
        /// <summary>
        /// 连接字符串
        /// </summary>
        public static readonly string connStr = ConfigurationManager.ConnectionStrings["local"].ConnectionString;

        /// <summary>
        /// 1. Execute insert, update, delete
        /// </summary>
        /// <param name="sql">sql command</param>
        /// <param name="type">sp or text</param>
        /// <param name="pms">sql parameters</param>
        /// <returns>query result</returns>
        public static int ExecuteNonQuery(string sql, CommandType type, params SqlParameter[] pms)
        {
            using (var conn = new SqlConnection(connStr))
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.CommandType = type;
                if (pms != null) cmd.Parameters.AddRange(pms);
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// 2. get a object that single query
        /// </summary>
        /// <param name="sql">sql command</param>
        /// <param name="type">sp or text</param>
        /// <param name="pms">sql parameters</param>
        /// <returns>query result</returns>
        public static object ExecuteScalar(string sql, CommandType type, params SqlParameter[] pms)
        {
            using (var conn = new SqlConnection(connStr))
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.CommandType = type;
                if (pms != null) cmd.Parameters.AddRange(pms);
                conn.Open();
                return cmd.ExecuteScalar();
            }
        }


        /// <summary>
        /// 3. Get a SqlDataReader object
        /// </summary>
        /// <param name="sql">sql command</param>
        /// <param name="type">sp or text</param>
        /// <param name="pms">sql parameters</param>
        /// <returns>query result</returns>
        public static SqlDataReader ExecuteReader(string sql, CommandType type, params SqlParameter[] pms)
        {
            var conn = new SqlConnection(connStr);
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.CommandType = type;
                if (pms != null) cmd.Parameters.AddRange(pms);

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
        /// 4. Get a DataTable object
        /// </summary>
        /// <param name="sql">sql command</param>
        /// <param name="type">sp or text</param>
        /// <param name="pms">sql parameters</param>
        /// <returns>query result</returns>
        public static DataTable ExecuteDataTable(string sql, CommandType type, SqlParameter[] pms)
        {
            var dt = new DataTable();
            using (var adapter = new SqlDataAdapter(sql, connStr))
            {
                adapter.SelectCommand.CommandType = type;
                if (pms != null) adapter.SelectCommand.Parameters.AddRange(pms);
                adapter.Fill(dt);
                return dt;
            }
        } 
    }
}
