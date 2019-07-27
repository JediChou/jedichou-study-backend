// FromObject.cs
// Author: Jedi Chou, skyzhx@163.com

using System;

class Employee {}

public class Program {
	static void Main() {
		Employee emp = new Employee();
		
		// ToString Method
		Console.WriteLine(emp);
		Console.WriteLine(emp.ToString());

		// GetType method
		Console.WriteLine(emp.GetType());
	}
}
