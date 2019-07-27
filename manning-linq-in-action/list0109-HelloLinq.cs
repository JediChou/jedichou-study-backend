// Listing 1.9
// Hello LINQ in C# improved with grouping and sorting
using System;
using System.Linq;

namespace Linq0109
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] words = { "hello", "wonderful", "linq", "beautiful", "world" };

			var groups =
				from word in words
				orderby word ascending
				group word by word.Length into lengthGroups
				orderby lengthGroups.Key descending
				select new {Length=lengthGroups.Key, Words=lengthGroups};

			foreach ( var group in groups )
			{
				Console.WriteLine("Words of length " + group.Length);
				foreach ( string word in group.Words )
					Console.WriteLine(" " + word);
			}
		}
	}
}
