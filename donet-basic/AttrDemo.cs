// File: AttrDemo.cs
// Description: How to create a custome attribute.
// Ref:https://docs.microsoft.com/zh-cn/dotnet/csharp/programming-guide/concepts/attributes/creating-custom-attributes

using System;

namespace AttrDemo
{
	[System.AttributeUsage(System.AttributeTargets.Class | System.AttributeTargets.Struct)]
	public class Author : System.Attribute
	{
		private string name;
		public double version;

		public Author(string name)
		{
			this.name = name;
			version = 1.0;
		}
	}

	[Author("Jedi Chou", version = 1.1)]
	public class UseAttr
	{
		public string Name { get; set; }
		public int Age { get; set; }
	}

	public class Program
	{
		public static void Main()
		{
			UseAttr uaObj = new UseAttr {
				Name = "CFA Coder",
				Age = 40 
			};

			Console.WriteLine("Name: {0}", uaObj.Name);
			Console.WriteLine("Age: {0}", uaObj.Age);

			object[] attrs = uaObj.GetType().GetCustomAttributes(true);
        	foreach (Attribute attr in attrs)
        		Console.WriteLine(attr);
		}
	}

}
