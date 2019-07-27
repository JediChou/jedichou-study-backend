using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cslab.Study201502091527.ThreadStudy
{
    /// <summary>
    /// Handle a task exception
    /// Reference book: Parallel Programming with Microsoft Visual Studio 2010 Step by Step
    /// Reference page: 32
    /// </summary>
    class ThreadThrowUnhandleException
    {
        public static void Run()
        {
            // Create a task reference.
            Task task = null;

            // Handle exception
            try
            {
                // Instance it.
                task = Task.Factory.StartNew(() =>
                {
                    int a = 5;
                    int b = 0;
                    int c = a / b;
                });
                task.Wait();
            }
            catch (AggregateException ae)
            {
                Debug.Assert(task != null, "task is null");
                Console.WriteLine("Task has " + task.Status.ToString());
                Console.WriteLine(ae.InnerException);
            }
        }
    }

    /// <summary>
    /// Handle multi-task exception
    /// Reference book: Parallel Programming with Microsoft Visual Studio 2010 Step by Step
    /// Reference page: 33
    /// </summary>
    class ThreadThrowMultiUnhandleException
    {
        private static void MethodA() { throw new Exception("TaskA Exception");}
        private static void MethodB() { throw new Exception("TaskB Exception");}
        private static void MethodC() { throw new Exception("TaskC Exception");}

        public static void Run()
        {
            try
            {
                var taskA = Task.Factory.StartNew(MethodA);
                var taskB = Task.Factory.StartNew(MethodB);
                var taskC = Task.Factory.StartNew(MethodC);
                Task.WaitAll(new[] { taskA, taskB, taskC});
            }
            catch (AggregateException ae)
            {
                foreach (var ex in ae.InnerExceptions)
                    Console.WriteLine(ex.Message);
            }
        }
    }

    /// <summary>
    /// Handle multi-task exception cross by call back
    /// Reference book: Parallel Programming with Microsoft Visual Studio 2010 Step by Step
    /// Reference page: 35
    /// </summary>
    class ThreadThrowMultiUnhandleExceptionByCallback
    {
        private static void MethodA() { throw new Exception("TaskA Exception"); }
        private static void MethodB() { throw new Exception("TaskB Exception"); }
        private static void MethodC() { throw new Exception("TaskC Exception"); }

        public static void Run()
        {
            try
            {
                Parallel.Invoke(new Action[] { MethodA, MethodB, MethodC});
            }
            catch (AggregateException ae)
            {
                ae.Handle(ex =>
                {
                    Console.WriteLine(ex.Message);
                    return true;
                });
            }
        }
    }
}
