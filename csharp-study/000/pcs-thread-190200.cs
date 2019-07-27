using System;
using System.Threading;

class ProCSharp_CreateThread
{
	public delegate int TakesAWhileDelegate(int data, int ms);
		
	static int TakesAWhile(int data, int ms)
	{
		Console.WriteLine("TakesAWhile");
		Thread.Sleep(ms);
		Console.WriteLine("TakesAWhile completed");
		return ++data;
	}

	static void Main()
	{
		// synchronous method call
		// TakesAWhile(1, 3000)

		// asynchronous by using a delegate
		TakesAWhileDelegate d1 = TakesAWhile;

		// Jedi: Notice, There has two threads !
		IAsyncResult ar = d1.BeginInvoke(1, 3000, null, null);  // thread 1
		while (!ar.IsCompleted)  								// thread 2
		{
			// doing something else in the main thread
			Console.Write(".");
			Thread.Sleep(50);
		}

		int result = d1.EndInvoke(ar);
		Console.WriteLine("Result: {0}", result);
	}
}
