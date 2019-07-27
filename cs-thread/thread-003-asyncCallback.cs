using System;
using System.Threading;
using System.Diagnostics;

public class AsyncCallback
{
	public delegate int TakesAWhileDelegate(int data, int ms);

	static int TakesAWhile(int data, int ms)
	{
		Console.WriteLine("TakesAWhile started");
		Thread.Sleep(ms);
		Console.WriteLine("TakesAWhile completed");
		return ++data;
	}

	static void TakesAWhileCompleted(IAsyncResult ar)
	{
		if (ar == null) throw new ArgumentNullException("ar");

		TakesAWhileDelegate dl = ar.AsyncState as TakesAWhileDelegate;
		Trace.Assert(dl != null, "Invalid object type");

		int result = dl.EndInvoke(ar);
		Console.WriteLine("result: {0}", result);
	}

	static void Main()
	{		
		// asynchronous by using a delegate
		TakesAWhileDelegate dl = TakesAWhile;
		dl.BeginInvoke(1, 5000, TakesAWhileCompleted, dl);

		for (int i = 0; i < 200; i++)
		{
			Console.Write(".");
			Thread.Sleep(50);
		}	
	}
}
