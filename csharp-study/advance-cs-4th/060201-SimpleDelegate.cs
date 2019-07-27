using System;

namespace Wrox.ProCSharp.SimpleDelegate
{
	// Define a delegate.
	delegate double DoubleOp(double x);
	
	// Define two operation method
	class MathsOperations {
		public static double MultiplyByTwo(double value) { return value*2;}
		public static double Square(double value) { return value*value;}
	}

	class Program
	{
		static void Main()
		{
			// Define a object array to store delegate operations
			DoubleOp [] operations = {
				new DoubleOp(MathsOperations.MultiplyByTwo),
				new DoubleOp(MathsOperations.Square)
			};
			
			// Output
			for( int i=0; i<operations.Length; i++) {
				Console.WriteLine("Using operations[{0}]:", i);
				ProcessAndDisplayNumber(operations[i], 2.0);
				ProcessAndDisplayNumber(operations[i], 7.94);
				ProcessAndDisplayNumber(operations[i], 1.414);
				Console.WriteLine();
			}
		}

		static void ProcessAndDisplayNumber(DoubleOp action, double value)
		{
			double result = action(value);
			Console.WriteLine(
				"Value is {0}, result of operation is {1}",
				value, result
			);
		}
	}
}
