// File: 01-srp.cs
// Single Responsibility Principle （单一职责原则）
// Ref: http://www.cnblogs.com/Ax0ne/p/3619481.html

namespace SingleResponsibilityPrinciple
{
    class DataAccess
    {
        public void InsertData()
        {
            System.Console.WriteLine("成功插入数据");
            System.Console.WriteLine("DataAccess.InsertData完成");
        }

        // 违反Single Responsibility Principle原则
        // 写日志的操作不应该放在这里。

        // public void WriteLog()
        // {
        //     Console.WriteLog("写入日志");
        //     Console.WriteLine("DataAccess.WriteLog日志写入完成");
        // }
    }

    class Logger
    {

        // 这样写才正确，目的是简化依赖关系
        // 原作者: 应该把不同的职责交给不同的对象处理

        public void Write(string msg)
        {
            System.Console.WriteLine("成功写入日志");
            System.Console.WriteLine("当前时间:{0}", System.DateTime.Now);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var da = new DataAccess();
                var log = new Logger();
                da.InsertData();
                log.Write("执行操作成功");
            }
            catch (System.Exception)
            {
                var log = new Logger();
                log.Write("执行操作失败");
            }
        }
    }
}