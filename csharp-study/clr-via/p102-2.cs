using System;
class ProgramP102_2
{
	static void Main()
	{
		Boolean found = false;	// found -> 0
		Int32 x = 100 + 20 + 3;	// x -> 123
		String s = "a " + "bc";	// s -> "a bc"
		Console.WriteLine("{0},{1},{2}", found, x, s);

		Int32 t = 100;			// assign
		Int32 y = t + 23;		// add and assign
		Boolean lessThanFifty = (y<50);	// less and assign
		Console.WriteLine("{0},{1},{2}", t, y, lessThanFifty);
	}
}
