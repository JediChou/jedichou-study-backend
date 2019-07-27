// File: p085-2.cs
using System;

class Employee {
	public string Name {get; set;}
}

class ProgramP085_2 {
	static void Main() {
		Object o = new Object();
		Employee e = o as Employee;

		Console.WriteLine(e);
		// Pop a NullReferenceException exception
		// e.ToString();
	}
}
