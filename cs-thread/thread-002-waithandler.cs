using System;
using System.Threading;

public class WaitHandler
{
	public delegate int TakesAWhileDelegate(int data, int ms);

	static int TakesAWhile(int data, int ms)
	{
		Console.WriteLine("TakesAWhile started");
		Thread.Sleep(ms);
		Console.WriteLine("TakesAWhile completed");
		return ++data;
	}

	static void Main()
	{		
		// asynchronous by using a delegate
		TakesAWhileDelegate dl = TakesAWhile;

		IAsyncResult ar = dl.BeginInvoke(1, 5000, null, null);
		while (true)
		{
			Console.Write(".");
			if (ar.AsyncWaitHandle.WaitOne(50, false))
			{
				Console.WriteLine("Can get the result now");
				break;
			}
		}

		int result = dl.EndInvoke(ar);
		Console.WriteLine("result is {0}", result);
	}
}
