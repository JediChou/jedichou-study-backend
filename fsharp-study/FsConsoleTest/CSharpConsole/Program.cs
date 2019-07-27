using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var result1 = MyMathLib.addition(1, 2);
            var result2 = MyMathLib.multiplication(4, 20);
            Console.WriteLine(result1);
            Console.WriteLine(result2);
        }
    }
}
