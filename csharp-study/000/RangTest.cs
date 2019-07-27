using System;
using System.Collections.Generic;

public class MyClass
{
	public static void Main(string[] args)
	{
		foreach(int i in range(-3))
			Console.WriteLine(i);
		
		Console.ReadLine();
	}
	
	public static List<int> range(int i)
	{
		if ( i <= 0) return new List<int>();
		var r = new List<int>();
		for(int c=0; c<i; c++)
			r.Add(c);
		return r;
	}
}