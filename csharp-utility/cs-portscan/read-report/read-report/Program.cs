using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace read_report
{
    class Program
    {
        static void Main(string[] args)
        {
            var files = Directory.GetFiles(@"D:\sqlscan\");
            foreach (var file in files)
            {
                var content = File.ReadAllLines(file);
                for (int i = 0; i < content.Length; i++)
                {
                    if (CheckSqlServer(content[i]))
                    {
                        string ip = FormatIP(content[i - 2]);
                        string port = FormatPort(content[i]);
                        Console.WriteLine("{0}: {1}", ip, port);
                    }
                }
            }
        }

        static bool CheckSqlServer(string mslog)
        {
            return mslog.Trim().Contains("1433") || mslog.Trim().Contains("3000");
        }

        static string FormatIP(string ip)
        {
            return ip.Split(':')[1].Trim();
        }

        static string FormatPort(string status)
        {
            if (status.Contains("1433")) return "1433";
            if (status.Contains("3000")) return "3000";
            return "";
        }
    }
}
