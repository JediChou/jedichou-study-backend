// listing .16 hello linq in c#
using System;
using System.Linq;

class P {
	static void Main() {
		var words = new string[]{"hello", "wonderful", "linq", "beautiful", "world"};
		var shortWords =
			from word in words
			where word.Length <=5
			select word;
		foreach(var word in shortWords)
			Console.WriteLine(word);
	}
}
