using System;
using System.Data;  // Non exists at uncompile code

internal class Employee {
	public string FirstName { get; set; }
	public string LastName { get; set; }
}

public sealed class Program {
	public static void Main() {
		// Don't need convert type
		Object obj = new Employee();

		// Need convert
		Employee obj2 = (Employee) obj;
	}
}
