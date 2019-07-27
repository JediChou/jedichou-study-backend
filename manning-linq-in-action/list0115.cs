// listing 1.15 hello linq to sql complete source code
using System;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;

class HelloLinqToSql
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

		static void Main()
		{
			// TODO: this demo can not run with my computer.
			string path = System.IO.Path.GetFullPath(@".\/NORTHWND.mdf");
			var db = new DataContext(path);
			var contacts =
				from contact in db.GetTable<Contact>()
				where contact.City == "Paris"
				select contact;

			foreach(var contact in contacts)
				Console.WriteLine("Bonjour"+contact.Name);
		}
	}
}
