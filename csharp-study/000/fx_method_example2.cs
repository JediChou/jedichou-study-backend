using System;
using System.Collections.Generic;

class MyClass
{
	void F1<T>(T[] a, int i) {	Console.WriteLine(i); }
	void F1(int i) { Console.WriteLine(i); }
}

class SubClass : MyClass {}

public class program
{
	public static void Main(string[] args)
	{
		var t = new SubClass();
	}
}