// File name: DelegateInCSharp.cs
// Reference by: c-sharpcorner.com/UploadFile/484ad3/delegate-in-C-Sharp/
// Description:
//   Delegate in C#
//   By Anupam Jain on Feb 16, 2015
//   In this article you will learn Delegate in C#

using System;

class Program
{
	// step 1: write the method that the delegate will point to
	static int PrintString(string s)
	{
		Console.WriteLine(s);
		return string.IsNullOrEmpty(s) ? 0:s.Length;
	}

	// step 2: define the delegate type
	delegate int StringAction(string s);

	static void Main()
	{
		// step 3: create delegate instance.
		// step 4: wrie delegate instance with the method in step1
		var stringAction = new StringAction(Program.PrintString);

		// step 5: invoke the method using delegate
		var result = stringAction("Hello World!");
		Console.WriteLine("The length is {0}", result);
	}
}
