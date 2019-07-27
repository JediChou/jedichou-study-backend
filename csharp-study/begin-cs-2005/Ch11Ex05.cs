// File name: Ch11Ex05.cs
// Description: Sort list.

namespace Ch11Ex05
{
	using System;
	using System.Text;
	using System.Collections;
	using System.Collections.Generic;

	/// <summary>
	/// Class Person
	/// </summary>
	class Person : IComparable
	{
		public string Name;
		public int Age;

		public Person(string name, int age)
		{
			Name = name;
			Age = age;
		}

		public int CompareTo(object obj)
		{
			if (obj is Person)
			{
				Person otherPerson = obj as Person;
				return this.Age - otherPerson.Age;
			} else {
				var message = "Object to compare to is not a person object";
				throw new ArgumentException(message);
			}
		}
	}

	/// <summary>
	/// Class PersonComparerName
	/// </summary>
	public class PersonComparerName : IComparer
	{
		public static IComparer Default = new PersonComparerName();

		public int Compare(object x, object y)
		{
			if ( x is Person && y is Person)
			{
				return Comparer.Default.Compare(
					((Person)x).Name, ((Person)y).Name
				);
			} else {
				throw new ArgumentException(
					"One or both objects to compare are not Person objects."
				);
			}
		}
	}

	// Program start here!
	class Program
	{
		static void Main(string[] argv)
		{
			// Define variables
			var list = new ArrayList();
			list.Add(new Person("Jim", 30));
			list.Add(new Person("Bob", 25));
			list.Add(new Person("Bet", 27));
			list.Add(new Person("Eva", 22));

			// Before sort
			Console.WriteLine("==============================");
			printlist(list);

			// Execute class's sort method (order by age)
			Console.WriteLine("==============================");
			list.Sort();
			printlist(list);

			// Execute user defined sort method (order by name)
			Console.WriteLine("==============================");
			list.Sort(PersonComparerName.Default);
			printlist(list);
		}

		// a help method
		static void printlist(ArrayList list)
		{
			foreach (Person elt in list)
				Console.WriteLine("{0}, {1}", elt.Name, elt.Age);
		}
	}
}
