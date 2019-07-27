using System;
using System.Collections;
using System.Collections.Generic;

public class MyClass
{
	public static void RunSnippet()
	{
		foreach(int i in Power(2, 8))
		{
			Console.Write("{0} ", i);
		}
	}
	
	public static IEnumerable Power(int number, int exponent)
	{
		int counter = 0;
		int result = 1;
		while (counter++ < exponent)
		{
			result = result * number;
			yield return result;
		}
	}
	
	#region Helper methods
	
	public static void Main()
	{
		try
		{
			RunSnippet();
		}
		catch (Exception e)
		{
			string error = string.Format("---\nThe following error occurred while executing the snippet:\n{0}\n---", e.ToString());
			Console.WriteLine(error);
		}
		finally
		{
			Console.Write("Press any key to continue...");
			Console.ReadKey();
		}
	}

	private static void WL(object text, params object[] args)
	{
		Console.WriteLine(text.ToString(), args);	
	}
	
	private static void RL()
	{
		Console.ReadLine();	
	}
	
	private static void Break() 
	{
		System.Diagnostics.Debugger.Break();
	}

	#endregion
}