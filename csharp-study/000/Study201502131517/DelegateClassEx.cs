using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace cslab.Study201502131517
{
    public class DelegareUsage
    {
        public delegate void MyDelegate(int number);
    }

    public class UseDelegate
    {
        public delegate void MyDelegate(int number);
        
        public static void Run()
        {
            var del = new MyDelegate(TimeTakingFunction);
            del += AnotherTimeTakinFunction;
            del.Invoke(10);
            Console.WriteLine("In the main");
        }

        public static void Display(int display)
        {
            Console.WriteLine(display);
            Console.ReadKey();
        }

        public static void TimeTakingFunction(int display)
        {
            Thread.Sleep(5000);
            Console.WriteLine("first time taking function " + display);
        }

        public static void AnotherTimeTakinFunction(int display)
        {
            Thread.Sleep(5000);
            Console.WriteLine("second time taking function " + display);
        }
    }
}
