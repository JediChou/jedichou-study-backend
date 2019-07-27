namespace PrintAPattern
{
	using System;
	class Program
	{
		static void Main()
		{
			// One
			for(int i=0; i<=4; i++)
			{
				for(int j=0;j<=i;j++)
					Console.Write("*");
				Console.WriteLine();
			}

			// Two
			Console.WriteLine();
			for(int i=0; i<=4; i++)
			{
				for(int j=i;j>=0;j--)
					Console.Write("*");
				Console.WriteLine();
			}
		}
	}
}
