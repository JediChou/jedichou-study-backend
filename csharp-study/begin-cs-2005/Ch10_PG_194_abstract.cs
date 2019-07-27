// Filename: Ch10_PG_194_abstract.cs
// Description: How to use abstract methods.

using System;

namespace ProgrammingCSharp10
{
	public abstract class BaseClass
	{
		public abstract void getMessage(); 
	}

	public class DerivedClass : BaseClass
	{
		public override void getMessage()
	       	{ 
			Console.WriteLine("override abstract method");
		}

		public static void Main(string[] args)
		{
			DerivedClass myobj = new DerivedClass();
			myobj.getMessage();
		}
	}
}
