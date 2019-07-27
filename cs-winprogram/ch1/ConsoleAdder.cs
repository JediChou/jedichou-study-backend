// --------------------------------------------------------
// Microsoft C# Windows Programming
// ConsoleAdder.cs @ 2001 by Charles Petzold
// --------------------------------------------------------

using System;

class ConsoleAdder
{
	public static void Main()
	{
		int a = 1509;
		int b = 744;
		int c = a + b;

		// 1st style
		Console.Write("The sum of ");
		Console.Write(a);
		Console.Write(" and ");
		Console.Write(b);
		Console.Write(" equals ");
		Console.WriteLine(c);

		// 2nd style
		Console.WriteLine("The sum of " + a + " and " + b + " equals " + c);

		// 3rd style
		Console.WriteLine("The sum of {0} and {1} equlas {2}", a, b, c);
	}
}
