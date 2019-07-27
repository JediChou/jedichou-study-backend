// File name: 040203-AbstractClass.cs
// Date: 2014-7-29-10-08
// Description: How to define and use abstract class
// From Profesional CSharp Programming, Page 103/1220

using System;

abstract class Building { public abstract decimal getCost(); }
class Hotel : Building { public override decimal getCost() {return 100;} }

class Program {
	static void Main(string[] args) {
		Console.WriteLine(new Hotel().getCost());
	}
}

