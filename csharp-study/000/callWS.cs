using System;
using System.Collections.Generic;
using System.Text;

namespace callWS
{
    class Program
    {
        static void Main(string[] args)
        {
            // 申明Web Service
            BingWS.Service1 ws = new BingWS.Service1();

            Console.WriteLine(ws.HelloWorld());
            Console.ReadLine();
        }
    }
}
