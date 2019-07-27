using System;
using System.Collections.Generic;
using System.Linq;

namespace UseGeneric
{
	public class MyClass<T>
	{
		public void Compareme(T v1, T v2)
		{
			Console.WriteLine( 
				v1.Equals(v2) ? 
				"The value is matching" : 
				"The value is not matching"
			);
		}
	}
	
	class Program
	{
		static void Main(string[] args)
		{
			MyClass<string> objmyint = new MyClass<string>();
			objmyint.Compareme("Amit", "Jedi");
			Console.WriteLine();
		}
	}
}
