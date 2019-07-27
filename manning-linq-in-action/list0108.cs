// listing 1.8 old-school version of hello linq

class P { static void Main(){
	string[] words = {"hello", "wonderful", "linq", "beautiful", "world"};
	foreach(string word in words)
		if(word.Length <=5)
			System.Console.WriteLine(word);
}}
