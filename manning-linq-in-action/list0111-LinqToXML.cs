// Listing 1.11 Hello LINQ to XML in C#
using System;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace List0111
{
	class Book
	{
		public string Publisher;
		public string Title;
		public int Year;

		public Book(string title, string publisher, int year)
		{
			Title = title;
			Publisher = publisher;
			Year = year;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			var books = new Book[]
			{
				new Book("Ajax in Action", "Manning", 2005),
				new Book("Windows Forms in Action", "Manning", 2006),
				new Book("RSS and Atom in Action", "Manning", 2006),
			};

			var xml = new XElement(
				"book",
				from book in books
				where book.Year == 2006
				select new XElement("book",
					new XAttribute("title", book.Title),
					new XElement("publisher", book.Publisher)
				)
			);

			Console.WriteLine(xml);
		}
	}
}
