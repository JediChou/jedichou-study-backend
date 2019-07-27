// File name: Ch11Ex110202Lab.cs
// Description: A demo for operator overload.

namespace Ch11Ex110202Lab
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Text;

	class Person { 
		public int age;
		public Person(int age) { this.age = age; }
		public static int operator + (Person first, Person second)
		{
			return first.age + second.age;
		}
	}

	class Program
	{
		static void Main(string[] argv)
		{
			var jedi = new Person(36);
			var kiwi = new Person(2);
			Console.WriteLine(jedi + kiwi);
		}
	}

}
