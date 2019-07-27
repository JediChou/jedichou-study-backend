// MinAndMax.cs @ 2001 Charles Petzold
using System;
class MinAndMax
{
	static void Main()
	{
		Console.WriteLine("sbyte:\t\t{0} to {1}", sbyte.MinValue, sbyte.MaxValue);
		Console.WriteLine("byte:\t\t{0} to {1}", byte.MinValue, byte.MaxValue);
		Console.WriteLine("short:\t\t{0} to {1}", short.MinValue, short.MaxValue);
		Console.WriteLine("ushort:\t\t{0} to {1}", ushort.MinValue, ushort.MaxValue);
		Console.WriteLine("int:\t\t{0} to {1}", int.MinValue, int.MaxValue);
		Console.WriteLine("long:\t\t{0} to {1}", long.MinValue, long.MaxValue);
		Console.WriteLine("float:\t\t{0} to {1}", float.MinValue, float.MaxValue);
		Console.WriteLine("double:\t\t{0} to {1}", double.MinValue, double.MaxValue);
		Console.WriteLine("decimal:\t{0} to {1}", decimal.MinValue, decimal.MaxValue);
	}
}
