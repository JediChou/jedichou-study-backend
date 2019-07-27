// File: 02-ocp.cs
// Open Close Principle (开闭原则)
// Ref: http://www.cnblogs.com/Ax0ne/p/3619481.html
// Ref: 认为软件应该是对扩展开放的，而对修改是关闭的

namespace OpenClosePrinciple
{
    using System;

    /// <summary>
    /// 数据操作的抽象类
    /// </summary>
    abstract class DataProvider
    {
        public abstract void OpenConnection();
        public abstract void CloseConnection();
        public abstract void ExecuteCommand();
    }

    /// <summary>
    /// MSSQL的数据操作类
    /// </summary>
    class SqlDataProvider: DataProvider
    {
        public override void OpenConnection() { Console.WriteLine("打开MSSQL连接"); }
        public override void CloseConnection() { Console.WriteLine("关闭MSSQL连接");}
        public override void ExecuteCommand() { Console.WriteLine("执行MSSQL的Command");}
    }

    /// <summary>
    /// Oracle的数据操作类
    /// </summary>
    class OracleProvider: DataProvider
    {
        public override void OpenConnection() { Console.WriteLine("打开Oracle连接"); }
        public override void CloseConnection() { Console.WriteLine("关闭Oracle连接");}
        public override void ExecuteCommand() { Console.WriteLine("执行Oracle的Command");}
    }

    /// <summary>
    /// 执行测试
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            DataProvider dp;

            // 进行MSSQL的数据库操作
            dp = new SqlDataProvider();
            dp.OpenConnection();
            dp.ExecuteCommand();
            dp.CloseConnection();

            // 进行Oracle的数据库操作
            dp = new OracleProvider();
            dp.OpenConnection();
            dp.ExecuteCommand();
            dp.CloseConnection();
        }
    }
}