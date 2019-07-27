// 130301-ThreadSample.cs
using System;
using System.Threading;

class EntryPoint
{
	static int interval;

	/// <summary>
	/// Program start here
	/// </summary>
	static void Main()
	{
		Console.Write("Interval to display results at? >");
		interval = int.Parse(Console.ReadLine());
		Thread thisThread = Thread.CurrentThread;
		thisThread.Name = "Main Thread";

		ThreadStart workerStart = new ThreadStart(StartMethod);
		Thread workerThread = new Thread(workerStart);
		workerThread.Name = "Worker";
		workerThread.Start();

		DisplayNumbers();
		Console.WriteLine("Main Thread Finished");

		Console.ReadLine();
	}  // Main method end.

	/// <summary>
	/// DisplayNumbers
	/// </summary>
	static void DisplayNumbers()
	{
		// Get name of current thread
		Thread thisThread = Thread.CurrentThread;
		string name = thisThread.Name;
		
		// Output
		Console.WriteLine("Starting thread: "+name);
		Console.WriteLine(name + ": Current Culture = " + thisThread.CurrentCulture);
		for( int i = 1 ; i <= 8*interval; i++)
			if( i % interval == 0)
				Console.WriteLine(name + ": count has reached " + i);
	}  // DisplayNumbers method end.

	/// <summary>
	/// StartMethod
	/// </summary>
	static void StartMethod()
	{
		DisplayNumbers();
		Console.WriteLine("Worker Thread Finished");
	}  // StartMethod end.
}
