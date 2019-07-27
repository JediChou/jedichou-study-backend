using System;
using System.Collections.Generic;
using System.Text;

public class MyClass
{
	// At donet 3.5, you must bing a type for IEnumerable interface.
	// But this iterator doesn't important. Pls check next code snippet.
	public static IEnumerable<string> SimpleList()
	{
		yield return "string 1";
		yield return "string 2";
		yield return "string 3";
	}
	
	public static void Main(string[] args)
	{
		foreach (string item in SimpleList())
			Console.WriteLine(item);
		
		Console.ReadKey();
	}
}