using System;
using System.Collections.Generic;
// using System.Diagnostics;
using System.Diagnostics;

class Program
{
	const int _max = 100000;

	static void Main()
	{
		var list = new List<string>();
		var link = new LinkedList<string>();
		
		// ... Add elements.
		for (int i = 0; i < 1000; i++)
		{
			list.Add("OK");
			link.AddLast("OK");
		}

		// check list
		var s1 = new Stopwatch();
		s1.Start();
		for (int i = 0; i < _max; i++)
			foreach (string v in list)
				if (v.Length != 2)
					throw new Exception();
		s1.Stop();

		// check linked list
		var s2 = new Stopwatch();
		s2.Start();
		for (int i = 0; i < _max; i++)
			foreach (string v in link)
				if (v.Length != 2)
					throw new Exception();
		s2.Stop();

		// output runtime
		Console.WriteLine(((double)(s1.Elapsed.TotalMilliseconds * 1000000) / _max).ToString("0.00 ns"));
		Console.WriteLine(((double)(s2.Elapsed.TotalMilliseconds * 1000000) / _max).ToString("0.00 ns"));
	}
}
