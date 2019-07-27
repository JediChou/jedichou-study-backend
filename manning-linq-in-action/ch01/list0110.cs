// manning linq action
// list 1-11
// hello linq to xml

using System;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

class Book
{
	public string Publisher { get; set; }
	public string Title { get; set; }
	public int Year { get; set; }
}

static class List0111
{
	static void Main()
	{
		var books = new Book[]
		{
			new Book {Title="Ajax in Action", Publisher="Manning", Year=2005},
			new Book {Title="Windows Forms in Action", Publisher="Manning", Year=2006},
			new Book {Title="RSS and Atom in Action", Publisher="Manning", Year=2006},
		};

		var xml = new XElement("books",
			from book in books
			// where book.Year == 2006
			select new XElement("book",
				new XAttribute("title", book.Title),
				new XElement("publisher", book.Publisher)
			)
		);

		Console.WriteLine(xml);
	}
}
