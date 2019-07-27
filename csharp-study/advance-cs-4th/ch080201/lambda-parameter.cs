using System;
using System.IO;

class Program {
	
	// Demo 1
	static void Parameter_Output1() {
		Func<string, string> oneParam = s => ("anything");
		Console.WriteLine(oneParam("test"));
	}
	
	// Demo 2
	public static void Parameter_Output2() {
		Func<double, double, double> twoParams = (x, y) => x*y;
		Console.WriteLine(twoParams(3, 2));
	}
	
	// Demo 3
	public static void Parameter_Output3() {
		Func<double, double, double> twoParamsWithType = (double x, double y) => x*x + y*y;
		Console.WriteLine(twoParamsWithType(3, 4));
	}
	
	// Start
	static void Main() {
		Parameter_Output1();
		Parameter_Output2();
		Parameter_Output3();
	}
	
}