// Listing 1.6 Hello Linq in C#
using System;
using System.Linq;

namespace list0106 {
	class HelloWorld {
		static void Main() {
			string[] words = {"Hello", "Wonderful", "Linq", "Beautiful", "World"};			
			var shortWords =
				from word in words
				where word.Length <= 5
				select word;

			foreach( var word in shortWords )
				Console.WriteLine(word);
		}
	}
}
