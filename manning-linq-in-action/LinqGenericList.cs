// LinqGenericList.cs
// Linq in Action, Page 116

using System;
using System.Collections.Generic;
using System.Linq;

class Book { 
	public string Title {get; set;} 
}

class LinqGenericList  {
	static void Main() {
		var books = new List<Book>() {
			new Book { Title = "Linq in Action" },
			new Book { Title = "Linq for Run" },
			new Book { Title = "Extreme Linq" }
		};

		var titles = books
			.Where (book => book.Title.Contains("Action"))
			.Select (book => book.Title);

		foreach (var title in titles.ToList())
			Console.WriteLine(title);
	}
}


