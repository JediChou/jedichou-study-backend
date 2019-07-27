// Linq in Action, Page 93
// Code lsit 4-5

using System;
using System.Collections.Generic;
using System.Linq;

static class TestDictionary
{
	static void Main()
	{
		var nums = new Dictionary<int, string>();
		nums.Add(0, "zero");
		nums.Add(1, "un");
		nums.Add(2, "deux");
		nums.Add(3, "trois");
		nums.Add(4, "quatre");

		var evenNums =
			from entry in nums
			where (entry.Key % 2) == 0
			select entry.Value;

		foreach(var value in evenNums.ToList())
			Console.WriteLine(value);
	}
}
