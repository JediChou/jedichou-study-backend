// Programming Microsoft LINQ in Microsoft .NET Framework 4
// From Page 24
// Listing 2-1, A simple query expression in C#

using System;
using System.Linq;
using System.Collections.Generic;

public class Developer {
	public string Name;
	public string Language;
	public int Age;
}

class App {
	static void Main() {
		var developers = new Developer[] {
			new Developer {Name="Paolo", Language="C#"},
			new Developer {Name="Marco", Language="C#"},
			new Developer {Name="Frank", Language="VB.NET"}};

		var developersUsingCSharp =
			from d in developers
			where d.Language == "C#"
			select d.Name;

		foreach(var name in developersUsingCSharp)
			Console.WriteLine(name);
	}
}
