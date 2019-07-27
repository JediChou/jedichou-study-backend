// File name 030202-CallMethod.cs
// Create by Jedi at 2013-4-16 13:54 PM.
// The code from <Profesional C# Programming>, zhcn-4th, page 76

using System;

namespace Wrox.ProCSharp.MathTestSample
{
	class MainEntryPoint
	{
		static void Main(string[] args)
		{
			// Try calling some static functions
			Console.WriteLine("Pi is " + MathTest.GetPi() );
			int x = MathTest.GetSquareOf(5);
			Console.WriteLine("Square of 5 is " + x);

			// Instantiate at MathTest object
			MathTest math = new MathTest();	// this is C#'s of
											// instantiating a reference type

			// Call non-static methods
			math.value = 30;
			Console.WriteLine("Value field of math variable contains " + math.value);
			Console.WriteLine("Square of 30 is " + math.GetSquare() );
		}
	}

	class MathTest
	{
		public int value;
		public int GetSquare() { return value * value; }
		public static int GetSquareOf(int x) { return x*x; }
		public static double GetPi() { return 3.14159; }
	}
}

