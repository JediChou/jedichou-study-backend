// Filename: Ch10_PG_194.cs
// Description: you can't modify readonly field

using System;

namespace programming
{
	public class MyClass
	{
		public readonly int intA = 17;
		public int intB = 20;
	}

	public class Program
	{
		public static void Main(string[] args)
		{
			MyClass myobj = new MyClass();
			Console.WriteLine(myobj.intA);
			Console.WriteLine(myobj.intB);

			// you can not modify intA value.
			// myobj.intA = 20;
			// myobj.intB = 20;
		}
	}
}
