// ref: Pro C# 2010 and the .NET 4 platform
// page 385
// author: Jedi Chou, 2016.3.25, 22:25

using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

class LinqRetValues {

	static IEnumerable<string> GetStringSubset() {
		string[] colors = {
			"Light Red", "Green", "Yellow",
			"Dark Red", "Red", "Purple"
		};

		// need use IEnumerable<string>
		IEnumerable<string> theRedColors = 
			from c in colors 
			where c.Contains("Red") 
			select c;

		return theRedColors;
	}

	static void Main(string[] args) {
		var subset = GetStringSubset();
		foreach(var color in subset)
			Console.WriteLine(color);
	}

}
