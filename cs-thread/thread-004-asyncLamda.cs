using System;
using System.Threading;
using System.Diagnostics;

public class AsyncLamda
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
		TakesAWhileDelegate dl = TakesAWhile;

		dl.BeginInvoke(1, 5000, 
			ar => {
				int result = dl.EndInvoke(ar);
				Console.WriteLine("result: {0}", result);
			}, dl
		);

		for (int i = 0; i < 200; i++)
		{
			Console.Write(".");
			Thread.Sleep(50);
		}	
	}
}