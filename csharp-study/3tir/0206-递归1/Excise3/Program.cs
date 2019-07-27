using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excise3
{
    class Program
    {
        static void Main(string[] args)
        {
            recuse();
            Console.WriteLine();
        }

        static int counter = 0;
        private static void recuse()
        {
            Console.Write("A");
            if (counter < 3)
            {
                counter++;
                recuse();
            }
            Console.Write("B");
        }
    }
}
