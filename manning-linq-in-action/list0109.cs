// listing 1.9 hello linq in c# improved with grouping and sorting

using System; using System.Linq;
class P {
	static void Main() {
		string[] words = {"hello", "wonderful", "linq", "beautiful", "world"};
		var groups =   // cool!
			from word in words
			orderby word ascending
			group word by word.Length into lengthGroups
			orderby lengthGroups.Key descending
			select new {Length=lengthGroups.Key, Words=lengthGroups};

		foreach(var group in groups) {
			Console.WriteLine("word of length " + group.Length);
			foreach(string word in group.Words)
				Console.WriteLine(" " + word);
		}
	}
}
