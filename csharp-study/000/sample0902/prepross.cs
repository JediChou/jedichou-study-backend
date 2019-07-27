// Title: Practical .NET2 and C#2
// Sub title: Harness the Platform, the Language, the Framework
// From - Page 252 zh edition
// Description: Use pre command and condition compile.
// Example 9-2

#define MARCOR1
#undef MARCOR1
using System;

public class Program {
	public static void Main() {
#if (MARCOR1)
		Console.WriteLine("MARCO1 is defined");
#elif (MARCOR2)
		Console.WriteLine("MARCO2 is defined");
#else
		Console.WriteLine("MARCO1 and MARCO2 are both undefined");
#endif
	}
}

// Jedi notes:
// 1. csc prepross.cs
// 2. csc prepross.cs /define:MARCOR1
// 3. csc prepross.cs /define:MARCOR2
