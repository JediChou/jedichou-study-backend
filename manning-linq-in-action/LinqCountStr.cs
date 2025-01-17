// Linq in Action, page 97
// Code list 4-6

using System;
using System.Collections.Generic;
using System.Linq;

static class LinqCountString
{
	static void Main()
	{
		var count =
			"Non-letter characters in this string: 8"
			.Where(c => !Char.IsLetter(c))
			.Count();
		Console.WriteLine(count);
	}
}
