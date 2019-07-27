// File: 04-isp.cs
// Desc: Interface Segregation Principle
// Desc: 认为多个特定客户端接口要好于一个宽泛用途的接口，也有单一职责的意思

namespace InterfaceSegregationPrinciple
{
    using System;

    /// <summary>
    /// 数据操作类接口
    /// </summary>
    interface IDataProvider
    {
        void OpenConnection();
        void CloseConnection();
    }

    /// <summary>
    /// MS Sql Server数据操作类接口
    /// </summary>
    interface ISqlDataProvider: IDataProvider
    {
        void ExecuteSqlCommand();
    }

    /// <summary>
    /// Oracle数据操作类接口
    /// </summary>
    interface IOracleDataProvider: IDataProvider
    {
        void ExecuteOracleCommand();
    }

    /// <summary>
    /// MSSQL数据操作类
    /// </summary>
    class SqlDataProvider: ISqlDataProvider
    {
        public void OpenConnection()
        {
            Console.WriteLine("打开MSSQL数据连接");
        }

        public void ExecuteSqlCommand()
        {
            Console.WriteLine("执行MSSQL命令");
        }

        public void CloseConnection()
        {
            Console.WriteLine("关闭MSSQL数据连接");
        }
    }

    /// <summary>
    /// Oracle数据操作类
    /// </summary>
    class OracleDataProvider: IOracleDataProvider
    {
        public void OpenConnection()
        {
            Console.WriteLine("打开Oracle数据连接");
        }

        public void ExecuteOracleCommand()
        {
            Console.WriteLine("执行Oracle命令");
        }

        public void CloseConnection()
        {
            Console.WriteLine("关闭Oracle数据连接");
        }
    }


    /// <summary>
    /// 测试类
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("开始执行测试");

            // 执行MSSQL的操作
            var sqlprovider = new SqlDataProvider();
            sqlprovider.OpenConnection();
            sqlprovider.ExecuteSqlCommand();
            sqlprovider.CloseConnection();

            // 执行Oracle的操作
            var oracleprovider = new OracleDataProvider();
            oracleprovider.OpenConnection();
            oracleprovider.ExecuteOracleCommand();
            oracleprovider.CloseConnection();

            Console.WriteLine("测试结束");
        }
    }
}