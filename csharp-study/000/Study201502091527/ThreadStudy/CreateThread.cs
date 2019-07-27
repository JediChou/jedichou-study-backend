using System;
using System.Threading.Tasks;

namespace cslab.Study201502091527.ThreadStudy
{
    class CreateThread
    {
        static void MethodA() { Console.WriteLine("MethodA"); }
        static void MethodB() { Console.WriteLine("MethodB"); }

        public static void Run()
        {
            var taskA = Task.Factory.StartNew(MethodA);
            var taskB = Task.Factory.StartNew(MethodB);
            Task.WaitAll(new[] { taskA, taskB });
        }
    }
}
