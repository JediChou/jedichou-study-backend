// 用来确认完美数

namespace PerfectNumber
{
	using System;

	class Program
	{
		static void Main(string[] args)
		{
			int number;
			int r = 0;
			int rev = 0;
			int original = 0;
			int s = 0;

			// Get user input
			Console.WriteLine("Enter a number \n");
			number = int.Parse(Console.ReadLine());
			
			// Process - Nice!
			original = number;
			for(int i=1; i<number; i++)
				if (number % i == 0)
					s += i;

			// Decision and output result
			var result = (number == s) ? "Perfect Number" : "No it is";
			Console.WriteLine(result);
		}
	}
}
