using System;
using System.Text.RegularExpressions;

namespace Wrox.ProCSharp.RegSample2
{
	class Program
	{
		static void WriteMatches(string text, MatchCollection matches)
		{
			Console.WriteLine("Original text was: \n\n" + text + "\n");
			Console.WriteLine("No. of matches:" + matches.Count);

			foreach(Match nextMatch in matches)
			{
				var Index = nextMatch.Index;
				var result = nextMatch.ToString();
				var charsBefore = (Index < 5) ? Index : 5;
				var fromEnd = text.Length - Index - result.Length;
				var charsAfter = (fromEnd < 5) ? fromEnd : 5;
				var charsToDisplay = charsBefore + charsAfter + result.Length;

				Console.WriteLine("Index: {0}, \tString: {1}, \t{2}",
					Index, result,
					text.Substring(Index - charsBefore, charsToDisplay));
			}
		}

		static void Find2()
		{
			var text = @"
			This comprehensive compendium provides a broad and
			thorogh investingation of all aspects of programming
			with ASP.NET revised and updated for the 2.0 Release
			of .NET, this book will give you the information
			you need to master ASP.NET and build a dynamic,
			success, enterprise Web applications.";

			var pattern = @"\bT";
			var matches = Regex.Matches(text, pattern, RegexOptions.IgnoreCase);
			WriteMatches(text, matches);
		}

		static void Main()
		{
			Find2();
		}
	}
}
