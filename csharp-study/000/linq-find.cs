using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
	static void Main()
	{
		var intArray = new int[] {1,2,3,4,5};
		var intList = intArray.ToList();

		var target = 4;
		var t = intList.Find(target);
		// Console.WriteLine(t);
	}
}
