using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using CFA;

namespace CFA_Monitor_Cmd
{
    class Program
    {
        /// <summary>
        /// 獲得當前程序佔用的內存數
        /// </summary>
        /// <returns></returns>
        static long GetCurrentProcessMemory()
        {
            return Process.GetCurrentProcess().PrivateMemorySize64;
        }

        /// <summary>
        /// 獲得IP列表
        /// </summary>
        /// <returns></returns>
        static string[] ReadIPs(string path)
        {
            try
            {
                return File.Exists(path) ? File.ReadAllLines(path) : null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        /// <summary>
        /// 主程序
        /// </summary>
        /// <param name="args">參數列表</param>
        static void Main(string[] args)
        {
            var servers = new List<CFA.Host>
            {   
                new CFA.Host { IP = "10.130.14.150" },
                new CFA.Host { IP = "10.130.14.160" },
                new CFA.Host { IP = "10.130.14.152" },
                new CFA.Host { IP = "10.130.14.107" },
                new CFA.Host { IP = "10.130.14.82" },
                new CFA.Host { IP = "10.130.14.147" },
                new CFA.Host { IP = "10.130.14.130" },
                new CFA.Host { IP = "10.134.33.87" },
                new CFA.Host { IP = "10.134.33.98" },
                new CFA.Host { IP = "10.134.33.170" },
                new CFA.Host { IP = "ray-pc" },
            };

            Parallel.ForEach(servers, serv =>
            {
                Console.WriteLine("{0} is {1}", serv.IP, serv.PingHost());
            });
        }
    }
}
