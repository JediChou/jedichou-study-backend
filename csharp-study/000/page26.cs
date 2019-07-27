using System;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelProg.Chapter01
{
    class page26
    {
        static void MethodA() { Thread.SpinWait(int.MaxValue); }
        static void MethodB() { Thread.SpinWait(int.MaxValue/2); }

        public static void run()
        {
            var TaskA = Task.Factory.StartNew(MethodA);
            var TaskB = Task.Factory.StartNew(MethodB);

            Console.WriteLine("TaskA id = {0}", TaskA.Id);
            Console.WriteLine("TaskB id = {0}", TaskB.Id);

            var tasks = new Task[] { TaskA, TaskB };
            int whichTask = Task.WaitAny(tasks);
            Console.WriteLine("Task {0} is the gold medal task.", tasks[whichTask].Id);
        }
    }
}
