// ---------------------------------------
// ConsoleTable1.cs
// Description: format
// Reference:
//   Microsoft C# Windows Programming
//   Page 9, Table 1-1
// Author: Jedi Chou
// Mail: skyzhx@163.com
// ---------------------------------------

using System;

class ConsoleFormat
{
	public static void Main()
	{
		int num = 12345;

		// Currency
		Console.WriteLine("Currency style: {0:C}",  num);
		Console.WriteLine("Currency style: {0:C1}", num);
		Console.WriteLine("Currency style: {0:C7}", num);
		Console.WriteLine();

		// Decimal
		Console.WriteLine("Decimal style: {0:D}",  num);
		Console.WriteLine("Decimal style: {0:D1}", num);
		Console.WriteLine("Decimal style: {0:D7}", num);
		Console.WriteLine();

		// Scientific
		Console.WriteLine("Scientific style: {0:E}",  num);
		Console.WriteLine("Scientific style: {0:E1}", num);
		Console.WriteLine("Scientific style: {0:E7}", num);
		Console.WriteLine();

		// Fixed point
		Console.WriteLine("Fixed point style: {0:F}",  num);
		Console.WriteLine("Fixed point style: {0:F1}", num);
		Console.WriteLine("Fixed point style: {0:F7}", num);
		Console.WriteLine();

		// General
		Console.WriteLine("General style: {0:G}",  num);
		Console.WriteLine("General style: {0:G1}",  num);
		Console.WriteLine("General style: {0:G7}",  num);
		Console.WriteLine();

		// Number
		Console.WriteLine("Number style: {0:N}",  num);
		Console.WriteLine("Number style: {0:N1}", num);
		Console.WriteLine("Number style: {0:N7}", num);
		Console.WriteLine();

		// Percent
		Console.WriteLine("Percent style: {0:P}",  num);
		Console.WriteLine("Percent style: {0:P1}", num);
		Console.WriteLine("Percent style: {0:P2}", num);
		Console.WriteLine();

		// Hexadecimal
		Console.WriteLine("Hexadecimal style: {0:X}",  num);
		Console.WriteLine("Hexadecimal style: {0:X1}", num);
		Console.WriteLine("Hexadecimal style: {0:X7}", num);
		Console.WriteLine();
	}
}
