// ref: Pro C# 2010 and the .NET 4 platform
// page 385
// author: Jedi Chou, 2016.3.25, 22:20

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class LinqBasedFieldsAreClunky {

	// define data source
	public static string[] currentVideoGames = {
		"Morrowind", "Uncharted 2", "Fallout 3",
		"Daxter", "System Shock 2"
	};

	// can not use var! need strong type.
	// and must use static keyword.
	private static IEnumerable<string> subset = 
		from g in currentVideoGames
		where g.Contains(" ")
		orderby g
		select g;

	// test it !
	public static void Main() {
		foreach(string item in subset)
			Console.WriteLine(item);
	}
}


