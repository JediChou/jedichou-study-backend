// File name: list0305.cs
// Reference by Linq in Action zh-cn, page 67-68

using System;
using System.Linq;

/// <summary>
/// A demo for linq feature
/// </summary>
static class QueryReuse
{
	/// <summary>
	/// Square method
	/// </summary>
	/// <param>A double number</param>
	static double Square(double n)
	{
		Console.WriteLine("Computing Square({0})...", n);
		return Math.Pow(n, 2);
	}
	
	/// <summary>
	/// Main method, program start here
	/// </summary>
	public static void Main()
	{
		// define a set of numbers and a linq query
		int[] numbers = {1, 2, 3};
		var query =
			from n in numbers
			select Square(n);
			
		// output
		foreach (var n in query)
			Console.WriteLine(n);
			
		// update these numbers and output it again
		Console.WriteLine("- Collection updated -");
		for (int i = 0; i < numbers.Length; i++)
			numbers[i] = numbers[i] + 10;
		foreach (var n in query)
			Console.WriteLine(n);
	}
}