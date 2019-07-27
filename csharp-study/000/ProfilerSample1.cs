using System;

public class ProfileSample1
{
	static void Main(string[] args)
	{
		int start = Environment.TickCount;
		for (int i = 0; i < 1000; i++)
		{
			string s = "";
			for (int j = 0; j < 100; j++)
			{
				s += "Outer index = ";
				s += i;
				s += " Inner index = ";
				s += j;
				s += " ";
			}
		}
		Console.WriteLine(
			"Program ran for {0} seconds",
			0.001 * (Environment.TickCount - start)
		);
	}
}
