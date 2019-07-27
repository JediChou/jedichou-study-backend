// ThreadPoolDemo.cs
// Ref: https://msdn.microsoft.com/zh-cn/library/system.threading.threadpool(v=vs.110).aspx
// Jedi Chou, 2016.3.14 10:57 AM

using System;
using System.Threading;

public class ThreadPoolDemo
{
	public static void Main(string[] args)
	{
		// Define Queue the task
		ThreadPool.QueueUserWorkItem(new WaitCallback(ThreadProc));
		ThreadPool.QueueUserWorkItem(new WaitCallback(ThreadProc2));

		Console.WriteLine("Main thread does some work, then sleeps.");
		// If you comment out the Sleep, the main thread exists before
		// the thread pool task runs. The thread pool uses background
		// threads, which do not keep the application running. (This
		// is a simple example of race condition.)
		Thread.Sleep(1000);

		Console.WriteLine("Main thread exits.");
	}

	// This thread procedure performs the task.
	static void ThreadProc(Object stateInfo)
	{
		Console.WriteLine("adsasdfasdf");
	}

	static void ThreadProc2(object stateInfo)
	{
		Console.WriteLine("ThreadProc2");
	}
}

