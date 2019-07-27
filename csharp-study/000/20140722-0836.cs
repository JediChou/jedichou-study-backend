// Reference 
//   http://en.wikibooks.org/wiki/C_Sharp_Programming/The_.NET_Framework/Threading
// C# Programming/The .NET Framework/Threading
// 
// The Thread class
//   The System.Threading.Thread class exposes basic functionality
//   for using threads. To create a thread, you simply create an
//   instance of Thread class with a ThreadStart or ParameterizedThreadStart
//   delegate pointing to the code the thread should start running.
//   For example:

using System;
using System.Threading;

public class Program
{
	private static void SecondThreadFunction()
	{
		while (true)
		{
			Console.WriteLine("Second thread says hello.");
			Thread.Sleep(1000);  // pause execution of the current thread
		}
	}
	
	public static void Main()
	{
		Thread newThread = new Thread(new ThreadStart(SecondThreadFunction));
		newThread.Start();

		while (true)
		{
			Console.WriteLine("First thread says hello.");
			Thread.Sleep(500);
		}
	}
}

