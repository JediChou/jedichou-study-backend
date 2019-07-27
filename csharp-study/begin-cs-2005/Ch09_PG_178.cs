// Filename: Ch09_PG_178.cs
// Description: How to pass base class parameters.

using System;

namespace SendParameter
{
	public class MyBaseClass
	{
		public MyBaseClass()
		{
			Console.WriteLine("MyBaseClass - Constructor");
		}

		public MyBaseClass(int i)
		{
			Console.WriteLine("MyBaseClass - Constructor send a int");
		}
	}

	public class MyDerivedClass : MyBaseClass
	{
		public MyDerivedClass()
		{
		}

		public MyDerivedClass(int i, int j) : base(i)
		{
		}

		public static void Main(string[] args)
		{
			Console.WriteLine("============================");
			MyDerivedClass myobj1 = new MyDerivedClass();
			Console.WriteLine("============================");
			MyDerivedClass myobj2 = new MyDerivedClass(1,2);
		}
	}
}
