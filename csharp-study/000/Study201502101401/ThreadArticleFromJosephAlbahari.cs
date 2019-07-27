using System;
using System.Threading;

namespace cslab.Study201502101401
{
    /// <summary>
    /// thread article code from Joseph Albahari.
    /// reference url: http://www.albahari.com/threading/#_Threads_vs_Processes
    /// </summary>
    class ThreadArticleFromJosephAlbahariSimplest
    {
        public static void Run()
        {
            var t = new Thread(() => { for(int i=0; i<1000; i++) Console.Write("y"); });
            t.Start();

            // Simultaneously, do something on the main thread.
            for(var i=0; i<1000; i++) Console.Write("x");
        }
    }

    /// <summary>
    /// thread article code from Joseph Albahari.
    /// reference url: http://www.albahari.com/threading/#_Threads_vs_Processes
    /// </summary>
    class ThreadArticleFromJosephAlbahariMainThreadAndNewThread
    {
        public static void Run()
        {
            new Thread(Go).Start(); // call Go() on a new thread
            Go();                   // call Go() on the main thread
        }

        static void Go()
        {
            // declare and use a local variable - 'cycles'
            for(var cycles = 0; cycles <5; cycles++) Console.Write('?');
        }
    }

    /// <summary>
    /// thread article code from Joseph Albahari.
    /// reference url: http://www.albahari.com/threading/#_Threads_vs_Processes
    /// </summary>
    class ThreadArticleFromJosephAlbahariSetAFlagForThred
    {
        static bool done;  // static field are shared between all threads

        public static void Run()
        {
            new Thread(Go).Start();
            new Thread(Go).Start();
            Go();
        }

        static void Go()
        {
            if (!done)
            {
                //done = true;
                Console.WriteLine("Done");
                done = true;
            }
        }
    }
}   
