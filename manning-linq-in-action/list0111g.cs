using System;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

class P {
	static void Main() {
		var books = new[] {
			new {Title="Ajax in Action", Publisher="Manning", Year=2005},
			new {Title="Windows Form in Action",  Publisher="Manning", Year=2006},
			new {Title="RSS and Atom in Action",  Publisher="Manning", Year=2006}
		};

		var xml = new XElement("books",
			from book in books
			where book.Year == 2006
			select new XElement("book",
				new XAttribute("title", book.Title),
				new XAttribute("publisher", book.Publisher)
			)
		);
		
		Console.WriteLine(xml);
	}
}
