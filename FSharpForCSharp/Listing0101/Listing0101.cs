using System;

public class Program
{
	static void Main()
	{
		int sum = 0;
		for (int i = 0; i <= 100; i++)
			if (i%2 != 0)
				sum += i;
		Console.WriteLine("the sum of odd numbers from 0 to 100 is {0}.", sum);
	}
}
