using System;

class Person {
	public string Name { get; set; }
	public int Age { get; set; }
	public string Email { get; set; }
}

class Student : Person {
	public string Tag { get; set; }
}

class Program {
	static void Main() {
		
		// no boxing
		Person p = new Student();

		// boxing and unboxing
		double a = 100.9;
		object o = a;
		double n = (double)o;
		
		// int n = (int) o;
		// but will pop a exception
		// message:
		//     System.InvalidCastException: Specified cast is not valid
	}
}
