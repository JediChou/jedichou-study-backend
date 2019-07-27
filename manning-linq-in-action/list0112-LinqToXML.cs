// Listing 1-13. Old-school version of Hello LINQ to XML
using System;
using System.Xml;

namespace List0113
{
	class Book
	{
		public string Title;
		public string Publisher;
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

			var doc = new XmlDocument();
			var root = doc.CreateElement("books");
			
			foreach (var book in books)
			{
				if (book.Year == 2006)
				{
					var element = doc.CreateElement("book");
					element.SetAttribute("title", book.Title);

					var publisher = doc.CreateElement("publisher");
					publisher.InnerText = book.Publisher;
					element.AppendChild(publisher);

					root.AppendChild(element);
				}
			}
			doc.AppendChild(root);

			doc.Save(Console.Out);
		}
	}
}
