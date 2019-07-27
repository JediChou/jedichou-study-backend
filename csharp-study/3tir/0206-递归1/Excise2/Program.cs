using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excise2
{
    class Program
    {
        static void Main(string[] args)
        {
            recuse();
        }

        private static void recuse()
        {
            // this code will get a memory leak
            int i = 100;
            Console.WriteLine("call recuse");
            recuse();
        }
    }
}
