using System;
using System.Collections.Generic;

public class MyClass
{
	public readonly string Name;
	private int intVal;
	
	public int Val
	{
		get
		{
			return intVal;
		}
		set
		{
			if(value > 0 && value <= 10)
				intVal = value;
			else
				throw (new ArgumentOutOfRangeException(
					"Val", value, "Value must be assiged a value between 0 and 10"
				));
		}
	}
	
	public override string ToString()
	{
		return "Name : " + Name + " \nVal : " +  Val;
	}
	
	private MyClass() : this("Default Name")
	{
	}
	
	public MyClass(string newName)
	{
		Name = newName;
		intVal = 0;
	}
	
	public static void Main(string[] args)
	{
		Console.WriteLine("Creating object myObj ... ");
		MyClass myObj = new MyClass("My Object");
		Console.WriteLine("myObj created.");
		
		for (int i = -1; i <= 0; i++)
		{
			try
			{
				Console.WriteLine("\nAttempting to assign {0} to myObj.Val.", i);
				myObj.Val = i;
				Console.WriteLine("myObj.Val now equals {0}", myObj.Val);
			}
			catch(ArgumentOutOfRangeException e)
			{
				Console.WriteLine("\nException {0} throw.", e.GetType().FullName);
				Console.WriteLine("message:\n{0}", e.Message);
			}
		}
		
		Console.WriteLine("\n" + "Outputting myObj.ToString() ... ");
		Console.WriteLine(myObj.ToString());
		Console.WriteLine("myObj.ToString() output");
		Console.ReadKey();
	}
}
