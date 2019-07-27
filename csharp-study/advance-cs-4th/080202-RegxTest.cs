using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Wrox.ProCSharp.RegxSample
{
	class Program
	{
		public static void Main()
		{
			var text = @"
			This comprehensive compendium provides a broad and
			thorogh investingation of all aspects of programming
			with ASP.NET revised and updated for the 2.0 Release
			of .NET, this book will give you the information
			you need to master ASP.NET and build a dynamic,
			success, enterprise Web applications.";

			var Pattern = @"\n";
			var Matches = Regex.Matches(text, Pattern,
										RegexOptions.IgnoreCase |
										RegexOptions.ExplicitCapture);

			foreach(Match matcher in Matches)
				Console.WriteLine(matcher.Index);
		}
	}
}
