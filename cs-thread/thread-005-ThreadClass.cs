using System;
using System.Threading;

public class ThreadingClass
{
    public static void Main()
    {
        var t1 = new Thread(ThreadMain);
        t1.Start();
        Console.WriteLine("This is the main thread.");
    }

    static void ThreadMain()
    {
        Console.WriteLine("Running is a thread");
    }
}