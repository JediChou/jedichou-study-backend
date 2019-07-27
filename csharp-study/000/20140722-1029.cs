// File name: 20140722-1029.cs
// From: Wikibooks
//   C# Programming/The .NET Framework/Threading
// Node: Asynchronous Delegates
//   Using anonymous delegates can lead to a lot of syntax, confusion
//   of scope, and lack of encapsulation. However with the use of
//   lambda expressions, some of these problems can be mitigated.
//   Instead of anonymous delegates, you can use asynchronous delegates
//   to pass and return data, all of which is type safe. It should be
//   noted that when you use an asynchronous delegate, you are actually
//   queuing a new thread to the thread pool. Also, using asynchronous
//   delegates forces you to use the asynchronous model.

using System;

public class Program
{
	delegate int del(int[] data);

	public static int SumOfNumbers(int[] data)
	{
		int sum = 0;
		foreach (int number in data)
			sum += number;

		return sum;
	}

	public static void Main()
	{
		int[] numbers = new int[] {1, 2, 3, 4, 5};
		del func = SumOfNumbers;

		// TODO, don't understand ! Jedi-20140722-1053
		IAsyncResult result = func.BeginInvoke(numbers, null, null);
		int sum = func.EndInvoke(result);

		Console.WriteLine("The result is: " + sum);
	}
}
