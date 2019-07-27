using System;
using System.Collections.Generic;

class Program
{
	public static void Main(string[] args)
	{
		var animal = new Animal();
		var cow = animal as Cow;
		Console.WriteLine(cow);
		Console.ReadLine();
	}
}

class Animal {}
class Cow : Animal { int age; }
