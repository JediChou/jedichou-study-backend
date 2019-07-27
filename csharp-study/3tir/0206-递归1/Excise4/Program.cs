using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excise4
{
    class Program
    {
        static void Main(string[] args)
        {
            recuse(0);
        }

        private static void recuse(int i)
        {
            Console.Write("A" + i);
            i++;
            if (i < 3) { recuse(i); }
            Console.Write("B" + i);
        }
    }
}
