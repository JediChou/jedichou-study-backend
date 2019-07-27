using System;
using System.Collections.Generic;

// Test construct method call sequence
namespace Ch09_JediLab_ForConstructMethod
{
	/// <summary>
	/// MyBaseClass - first class
	/// </summary>
	public class MyBaseClass
	{
		public MyBaseClass()
		{
			Console.WriteLine("MyBaseClass-Constrct-MyBaseClass()...");
		}
		
		public MyBaseClass(int i)
		{
			Console.WriteLine("MyBaseClass-Constrct-MyBaseClass(int i)...");
		}
	}
	
	/// <summary>
	/// MyDerivedClass - second class
	/// </summary>
	public class MyDerivedClass : MyBaseClass
	{
		public MyDerivedClass()
		{
			Console.WriteLine("MyDerivedClass-Construct-MyDerivedClass()");
		}
		
		public MyDerivedClass(int i)
		{
			Console.WriteLine("MyDerivedClass-Construct-MyDerivedClass(int i)");
		}
		
		public MyDerivedClass(int i, int j)
		{
			Console.WriteLine("MyDerivedClass-Construct-MyDerivedClass(int i, int j)");
		}
	}
	
	/// <summary>
	/// Check execute sequence. 
	/// </summary>
	public class testlab
	{
		public static void Main(String[] args)
		{
			// NO parameter
			MyBaseClass mbc1 = new MyBaseClass();
			MyDerivedClass mdc1 = new MyDerivedClass();
			
			// Have 1 parameter
			MyBaseClass mbc2 = new MyBaseClass(1);
			MyDerivedClass mdc2 = new MyDerivedClass(1);
			
			// Have many parameters
			MyDerivedClass mdc3 = new MyDerivedClass(0, 1);
			
			Console.ReadKey();
		}
	}
}
