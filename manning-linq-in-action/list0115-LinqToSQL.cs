// Listing 1.15 Hello LINQ to SQL complete source code
using System;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace List0115
{

	// lab without northwnd.mdf.So if you run it,
	// u will get a lot of error message. Jedi 2014-10-6

	static class HelloLinqToSql
	{
		[Table(Name="Contacts")]
		class Contact
		{
			[Column(IsPrimaryKey=true)]
			public int ContactID { get; set; }

			[Column(Name="ContactName")]
			public string Name { get; set; }

			[Column]
			public string City { get; set; }
		}

		static void Main()
		{
			var path = System.IO.Path.GetFullPath(@".\northwnd.mdf");
			var db = new DataContext(path);
			var contacts =
				from contact in db.GetTable<Contact>()
				where contact.City == "Paris"
				select contact;

			foreach (var contact in contacts)
				Console.WriteLine("Bonjour " + contact.Name);
		}
	}
}
