using System;
using System.Collections.Generic;

public class MyClass
{
	// Method : Normal.
	// Step-1 create a method for a delegate
	public static void DelegateMethod(string message)
	{
		Console.WriteLine(message);
	}
		
	// Method : callback
	public void MethodWithCallback(int param1, int param2, Del callback)
	{
		callback("The number is: " + (param1 + param2).ToString());
	}
	
	public static void Main(string[] args)
	{
		// Step-2 Instantiate the deleagte
		Del handler = DelegateMethod;
		
		// Step-3 call delegate method
		handler("");
		Console.ReadLine();
	}
}
