using System;
class Program
{
	static void Main()
	{
		string mid = ", middle part,";
		Func<string, string> lambda = param =>
		{
			param += mid;
			param += " and this was added to the string.";
			return param;
		};
		
		Console.WriteLine(lambda("Start of string"));
	}
}