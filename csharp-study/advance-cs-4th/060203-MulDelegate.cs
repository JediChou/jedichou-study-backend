namespace Wrox.ProCSharp.MultiDelegateSample
{
	using System;

	delegate void DoubleOp(double x);

	class MathOperation
	{
		public static void MultiplyByTwo(double value)
		{
			double result = value * 2;
			Console.WriteLine(
				"Multiplying by 2: {0} gives {1}",
				value, result
			);
		}

		public static void Square(double value)
		{
			double result = value * value;
			Console.WriteLine(
				"Squaring: {0} gives {1}",
				value, result
			);
		}
	}

	class Program
	{
		public static void Main(string[] args)
		{
			var operations = new DoubleOp(MathOperation.MultiplyByTwo);
			operations += new DoubleOp(MathOperation.Square);

			ProcessAndDisplayNumber(operations, 2.0);
			ProcessAndDisplayNumber(operations, 7.94);
			ProcessAndDisplayNumber(operations, 1.414);
		}

		static void ProcessAndDisplayNumber(DoubleOp action, double value)
		{
			Console.WriteLine(
				"\nProcessAndDisplayNumber called with value={0}", value
			);
			action(value);
		}ProcessAndDisplayNumber(operations, 2.0);
	}
}
