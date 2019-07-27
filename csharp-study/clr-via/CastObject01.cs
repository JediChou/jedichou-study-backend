using System;

internal class Employee {}
public sealed class Program {
	public static void Main() {
		// Don't be cast object.
		Object o = new Employee();
		Console.WriteLine(o);
		Console.WriteLine(o.GetType());
	}
}
