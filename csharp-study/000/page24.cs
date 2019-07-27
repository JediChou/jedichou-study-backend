using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;

namespace ParallelProg.Chapter01
{
    /// <summary>
    /// Simple Parallel Program
    /// </summary>
    class page24
    {
        static void MethodA() { Console.WriteLine("App-page24 MethodA"); }
        static void MethodB() { Console.WriteLine("App-page24 MethodB"); }

        public static void run()
        {
            var TaskA = Task.Factory.StartNew(MethodA);
            var TaskB = Task.Factory.StartNew(MethodB);
            Task.WaitAll(new Task[] { TaskA, TaskB });
        }
    }
}
