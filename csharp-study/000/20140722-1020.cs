// File name: 20140722-1020.cs
// From Wikibooks
//   C# Programming/The .NET Framework/Threading
// Node: Sharing Data
//   Although we could use ParameterizedThreadStart to pass parameter
//   to threads, it is not typesafe and is clumsy to use. We could
//   exploit anonymous delegates to share data between threads, 
//   however:

using System;
using System.Threading;

public class Program
{
	public static void Main()
	{
		int number = 1;
		Thread newThread = new Thread(new ThreadStart(delegate
		{
			while (true)
			{
				number++;
				Console.WriteLine("Second thread says " + number.ToString());
				Thread.Sleep(1);
			}
		}));

		newThread.Start();

		while (true)
		{
			number++;
			Console.WriteLine("First thread says " + number.ToString());
			Thread.Sleep(1);
		}
	}
}
