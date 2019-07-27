// File Name: Ex110502.cs
// Description:
//   Overload Person's operator.

namespace BeginCSharp_Ex110502
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

		// Execise answer. Operator overload.
		public static int operator + (Person p1, Person p2)	{ return p1.Age + p2.Age; }
		public static int operator - (Person p1, Person p2)	{ return p1.Age - p2.Age; }
		public static bool operator <  (Person p1, Person p2)	{ return p1.Age < p2.Age; }
		public static bool operator >  (Person p1, Person p2)	{ return p1.Age > p2.Age; }
		public static bool operator <= (Person p1, Person p2)	{ return p1.Age <= p2.Age; }
		public static bool operator >= (Person p1, Person p2)	{ return p1.Age >= p2.Age; }
	}

	class Program
	{
		static void Main(String[] args)
		{
			// Define
			var t1 = new Person("Jedi", 36);
			var t2 = new Person("Becky", 31);

			// Output
			Console.WriteLine("First is {0}, and age is {1}", t1.Name, t1.Age);
			Console.WriteLine("Other is {0}, and age is {1}", t2.Name, t2.Age);
			Console.WriteLine("Operator + result is: {0}", t1 + t2);
			Console.WriteLine("Operator - result is: {0}", t1 - t2);
			Console.WriteLine("Operator > result is: {0}", t1 > t2);
			Console.WriteLine("Operator < result is: {0}", t1 < t2);
			Console.WriteLine("Operator <= result is: {0}", t1 <= t2);
			Console.WriteLine("Operator >= result is: {0}", t1 >= t2);
		}
	}

}
