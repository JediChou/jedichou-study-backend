// File name: Ch10_PG_198.cs
// Description: Use field, method and properties

using System;

namespace _
{
	public class MyClass
	{
		public readonly string Name;
		private int intVal;
		
		public int Val
		{
			get { return intVal; }
			set 
			{
				if (value >= 0 && value <= 10)
					intVal = value;
				else
					throw (new ArgumentOutOfRangeException());
			}
		}

		public override string ToString()
		{
			return "Name: " + Name + "\nVal: " + Val;
		}

		private MyClass() : this("Default Name") {}
		public MyClass(string newName)
		{
			Name = newName;
			intVal = 0;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Creating object myobj ... ");
			MyClass myobj = new MyClass("My Object");
			Console.WriteLine("myobj created.");

			for (int i=-1; i<=0; i++)
			{
				try
				{
				}
				catch (Exception e)
				{
					Console.WriteLine("Except {0}:", e.GetType().FullName);
					Console.WriteLine("Message:\n\"{0}\"", e.Message);
				}
			}

			Console.WriteLine("\nOutputting myObj.ToString() ...");
			Console.WriteLine(myobj.ToString());
			Console.WriteLine("myobj.ToString() Output.");
		}
	}
}
