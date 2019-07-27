namespace PalindromeNumber
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
			Console.WriteLine("Enter a number \n");
			number = sbyte.Parse(Console.ReadLine());
			original = number;
			while(number > 0)
			{
				r = number % 10;
				rev = (rev*10) + r;
				number = number/10;
			}
			if(original == rev)
				Console.WriteLine("Palindrome Number");
			else
				Console.WriteLine("Not Palindrome Number");

		}
	}
}
