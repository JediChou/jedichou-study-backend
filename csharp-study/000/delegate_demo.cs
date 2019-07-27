using System;
using System.Collections.Generic;

public class Program
{
	delegate double ProcessDelegate(double param1, double param2);
	
	static double Multiply(double param1, double param2) {
		return param1 * param2;
	}
	
	static double Divide(double param1, double param2) {
		return param1 / param2;
	}
	
	static void Main(string[] args) {
		// Define a delegate
		ProcessDelegate process;
		
		// Accept user input
		Console.WriteLine("Enter 2 numbers separated with a comma:");
		string input = Console.ReadLine();
		
		// Convert user input
		int commaPos = input.IndexOf(',');
		double param1 = Convert.ToDouble(input.Substring(0, commaPos));
		double param2 = Convert.ToDouble(input.Substring(commaPos+1, input.Length - commaPos - 1));
		
		// Process:
		// 1. Accept operator
		// 2. Use delegate to bind method
		Console.WriteLine("Enter M to multiply or D to divide:");
		input = Console.ReadLine();		
		if (input == "M")
			// use delegate
			process = new ProcessDelegate(Multiply);
		else
			// use delegate
			process = new ProcessDelegate(Divide);
		
		// Output process result
		Console.WriteLine("Result: {0}", process(param1, param2));
	}
}