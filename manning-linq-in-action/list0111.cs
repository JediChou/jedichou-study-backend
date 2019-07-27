using System;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

class Book {
	public string Publisher;
	public string Title;
	public int Year;

	public Book(string title, string publisher, int year) {
		Title = title;
		Publisher = publisher;
		Year = year;
	}
}

class P {
	static void Main() {
		Book[] books = {
			new Book("Ajax in Action", "Manning", 2005),
			new Book("Windows Form in Action", "Manning", 2006),
			new Book("RSS and Atom in Action", "Manning", 2006)
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
