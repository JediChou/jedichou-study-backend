// 输出斐波那契数列

namespace FibonacciSeries
{
	using System;
	class Program
	{
		static void Main()
		{
			double number;
			double n1=0, n2=1, fib=0;

			// fibonacci series 0 1 1 2 3 5 8 11 19 ..... N
			Console.WriteLine("Input a number:");
			number = int.Parse(Console.ReadLine());

			// 输入的值不能太大
			Console.Write("{0} {1} ", n1, n2);
			for(int i=0; i<=number; i++)
			{
				fib = n1+n2;
				Console.Write(fib + " ");
				n1 = n2;
				n2 = fib;
			}
		}
	}
}
