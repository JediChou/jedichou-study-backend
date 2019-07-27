namespace Wrox.ProCSharp.String.ReplaceSample
{
	using System;

	class Program
	{
		static void Main()
		{
			var greeting = "Hello from all the guys at Wrox Press. ";
			greeting += "We do hope you enjoy this book as much as we ";
			greeting += "enjoyed writing it.";

			for(int i=(int)'z'; i>=(int)'a'; i--)
			{
				char old1 = (char)i;
				char new1 = (char)(i+1);
				greeting = greeting.Replace(old1, new1);
			}

			for(int i=(int)'Z'; i>=(int)'A'; i--)
			{
				char old1 = (char)i;
				char new1 = (char)(i+1);
				greeting = greeting.Replace(old1, new1);
			}

			Console.WriteLine("Encoded:\n" + greeting);
		}
	}
}
