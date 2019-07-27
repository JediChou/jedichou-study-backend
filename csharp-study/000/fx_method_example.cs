using System;
using System.Collections.Generic;

public class Fx_class
{
	public static int Find<T>(T[] items, T item)
	{
		return -1;
	}
}

public class program
{
	public static void Main(string[] args)
	{
		int t = Fx_class.Find<int>(new int[]{1,2,3,4,5}, 5);
		Console.WriteLine(t);
		Console.ReadLine();
	}
}