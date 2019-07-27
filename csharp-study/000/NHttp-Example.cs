using NHttp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHttp_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var server = new HttpServer())
            {
                server.RequestReceived += (s, e) =>
                {
                    using (var writer = new StreamWriter(e.Response.OutputStream))
                    {
                        writer.Write("Hello world!");
                    }
                };

                server.Start();

                Process.Start(String.Format("http://{0}/", server.EndPoint));

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
