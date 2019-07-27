using System;
using System.Threading;
using System.Threading.Tasks;

namespace cslab.Study201502091527.ThreadStudy
{
    class ThreadWaitAny
    {
        static void MethodA() { Thread.SpinWait(int.MaxValue); }
        static void MethodB() { Thread.SpinWait(int.MaxValue/2); }

        public static void Run()
        {
            var taskA = Task.Factory.StartNew(MethodA);
            var taskB = Task.Factory.StartNew(MethodB);
            Console.WriteLine("TaskA id = {0}", taskA.Id);
            Console.WriteLine("TaskB id = {0}", taskB.Id);

            var tasks = new[] {taskA, taskB};
            int whichTask = Task.WaitAny(tasks);
            Console.WriteLine("Task {0} is the gold medal task.", tasks[whichTask].Id);
        }
    }

    class UsingFunctionDelegates
    {
        public static void Run()
        {
            var task = Task<int>.Factory.StartNew(() => 42);
            task.Wait();
            Console.WriteLine(task.Result);
        }

        public static void Run2()
        {
            var task = new Task<int>(() => 42);
            task.Start();
            Console.WriteLine(task.Result);
        }

        public static void Run3()
        {
            var task = Task<int>.Factory.StartNew(val => ((string) val).Length, "JC");
            // Notice: The task already execute when Task.Factory.StartNew() create it.
            // task3.Start();
            task.Wait();
            Console.WriteLine(task.Result);
        } 
    }
}
