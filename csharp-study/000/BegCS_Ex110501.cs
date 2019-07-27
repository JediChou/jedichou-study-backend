// File Name: Ex110501.cs
// Description:
//   Create a set of Person object, and this set name is People.

namespace BeginCSharp_Ex110501
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Text;

	/// <summary>
	/// Person class
	/// </summary>
	class Person
	{
		private string name;
		private int age;

		public string Name { get { return name; } set { name = value; } }
		public int Age { get { return age; } set { age = value; } }
		public Person(string name, int age)
		{
			this.Name = name; this.Age = age;
		}
	}

	/// <summary>
	/// Peple class
	/// </summary>
	class People : CollectionBase
	{
		public void Add(Person person) { List.Add(person); }
		public void Remove(Person person) {	List.Remove(person); }
		public People() { }

		public Person this[int personIndex]
		{
			get { return (Person)List[personIndex]; }
			set { List[personIndex] = value; }
		}

		// Execise answer
		public Person this[string personName]
		{
			get
			{
				return (Person)List[getLocation(personName)];
			}
		}

		// Help method
		private int getLocation(string personName)
		{
			int i = 0;
			foreach(Person elt in List)
			{
				if (elt.Name == personName)
					return i;
				i++;
			}
			return -1;
		}
		
	}

	class Program
	{
		static void Main(String[] args)
		{
			// Define
			var people = new People();
			people.Add(new Person("Jedi", 36));
			people.Add(new Person("Kiwi", 2));
			people.Add(new Person("Becky", 31));

			// Output
			Person temp = people["Jedi"];
			Console.WriteLine("Name:{0}, Age:{1}", temp.Name, temp.Age);

		}
	}

}
