// File name: 20140722-0900
// Reference by wikibooks.
//   C# Programming/The .NET Framework/Threading
//
// Node: ParameterizedThreadStart
// The void ParameterizedThreadStart(object obj) delegate allows
// you to pass a parameter to the new thread:

using System;
using System.Threading;

public class Program
{
	private static void SecondThreadFunction(object param)
	{
		while (true)
		{
			Console.WriteLine("Second thread says " + param.ToString());
			Thread.Sleep(500);
		}
	}

	public static void Main()
	{
		Thread newThread = new Thread(new ParameterizedThreadStart(SecondThreadFunction));
		
		newThread.Start(1234);

		while (true)
		{
			Console.WriteLine("First thread says hello.");
			Thread.Sleep(1000);
		}
	}
}


