namespace NormalConsole
{
    using System;
    using System.Data.SqlClient;

    /// <summary>
    /// SqlConnectionStringBuilder的示例
    /// 参考URL: https://docs.microsoft.com/zh-cn/dotnet/api/system.data.sqlclient.sqlconnectionstringbuilder?view=netframework-4.8
    /// </summary>
    class Program
    {
        static void Main()
        {
            // 创建SqlConnectionStringBuilder实例, 并初始化部分连接字符串的值.
            // 如果输入的连接字符串存在Key/Value缺失, 则初始化会报异常.
            var connBuild = new SqlConnectionStringBuilder(GetConnectionString());

            // The input connection string used the
            // Server key, but the new connection string uses
            // the well-know Data Source key instead.
            Console.WriteLine(connBuild.ConnectionString);

            // Pass the SqlConnectionStringBuilder an existing
            // connection string, and you can retrieve and
            // modify any of the elements
            connBuild.ConnectionString = "server=(local);user id=ab:;" +
                "password=a!Pass113;initial catalog=AdventureWorks";

            // Now that the connection string has been parsed,
            // you can work with individual items.
            Console.WriteLine(connBuild.Password);
            connBuild.Password = "new@1Password";
            connBuild.AsynchronousProcessing = true;

            // You can refer to connection keys using string,
            // as well. When you use this technique (the default
            // Item property in Visual Basic, or the indexer in C#),
            // you can specify any synonym for the connection string key
            // name.
            connBuild["Server"] = ".";
            connBuild["Connect Timeout"] = 1000;
            connBuild["Trusted_Connection"] = true;

            // 输出连接字符串的其他项, 注意:key是大小写不敏感的.
            Console.WriteLine(connBuild.ConnectionString);
            Console.WriteLine(connBuild["Server"]);
            Console.WriteLine(connBuild["Initial Catalog"]);
            Console.WriteLine(connBuild["Integrated Security"]);
            Console.WriteLine(connBuild["User Id"]);
            Console.WriteLine(connBuild["Password"]);
            Console.WriteLine(connBuild["Asynchronous Processing"]);
            Console.WriteLine(connBuild["Connect Timeout"]);
        }

        private static string GetConnectionString()
        {
            // 这里的连接字符串可以从配置文件中获取
            return "Server=(local);Integrated Security=SSPI;" +
                "Initial Catalog=AdventureWorks";
        }
    }
}
