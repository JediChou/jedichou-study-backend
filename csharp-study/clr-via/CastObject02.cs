using System;

internal class Employee {}
public sealed class Program 
{
	public static void Main() 
	{
		// Get an error message:
		//   System.InvalidCastException
		
		Object o = new Object();
		Employee e = (Employee) o;
		Console.WriteLine(e);
		Console.WriteLine(e.GetType());
	}
}
