// File: awlinq-p46-01.cs
// List 3-1
// Query gets all contacts in the state of "WA"
// ordered by last name and then first name using
// extension method query syntax - see Output 3-1

using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

class Contact
{
	public string State { get; set; }
	public string LastName { get; set; }
	public string FirstName { get; set; }
}

class AwlinqP46
{
	static void Main()
	{
		List<Contact> contacts = new List<Contact> 
		{
			new Contact { State="WA", FirstName="Jedi", LastName="Chou" },
			new Contact { State="WA", FirstName="Fang", LastName="Chou" },
			new Contact { State="HB", FirstName="Becky", LastName="Wu" },
			new Contact { State="SZ", FirstName="Xixi", LastName="Chou" }
		};

		var q = contacts.Where( c => c.State == "WA")
				        .OrderBy( c=> c.LastName)
						.ThenBy( c=> c.FirstName);

		foreach (Contact c in q)
			Console.WriteLine("{0} {1}", c.FirstName, c.LastName);
	}
}
