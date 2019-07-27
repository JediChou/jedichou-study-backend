using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excise1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Please check Callstack
            Method1();
        }

        private static void Method1()
        {
            Method2();
        }

        private static void Method2()
        {
            Method3();
        }

        private static void Method3()
        {
            Console.WriteLine("Method3");
        }
    }
}
