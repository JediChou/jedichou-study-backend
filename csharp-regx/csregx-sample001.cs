using System;
class CSRegx_Sample001 {
	static void Main() {
		string band;
		band = "The Albion Band";
		Console.WriteLine(char.IsWhiteSpace(band,3));
		Console.WriteLine(char.IsPunctuation('A'));

		// Jedi: char.IsPunctuation() check ',.;*&$#, etc.
	}
}
