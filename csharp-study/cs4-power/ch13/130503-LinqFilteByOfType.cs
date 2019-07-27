// ref: Pro C# 2010 and the .NET 4 platform
// page 389
// Author: Jedi Chou, 2016.3.25, 22:50

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class LinqFilterByOfType {
	public static void Main(string[] args) {
		var stuff = new ArrayList();
		stuff.AddRange( new object[] {
			10, 400, 8, false,
			new object(), "string data"
		});

		var intByStuff = stuff.OfType<int>();

		foreach(var elt in intByStuff)
			Console.WriteLine(elt);
	}
}
