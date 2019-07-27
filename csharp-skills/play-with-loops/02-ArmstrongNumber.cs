namespace ArmstrongNumber
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
			// armstrong number
			Console.WriteLine("Enter a number \n");
			number = int.Parse(Console.ReadLine());
			original = number;
			while(number > 0)
			{
				r = number % 10;
				// 这个查找回文的算法是错的
				// rev = rev + (r*r*r);
				rev = (rev*10) + r; // <- 这个是对的！但说不清理由。
				number = number/10;
			}
			if(original == rev)
				Console.WriteLine("Palindrome Number");
			else
				Console.WriteLine("Not Palindrome Number");

		}
	}
}
