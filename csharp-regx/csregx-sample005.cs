using System;
class CSRegx_Sample005 {
	public static void Main(string[] args) {
		char[] myString = "hello string!".ToCharArray();
		Console.WriteLine(myString);

		// Create a substring
		for (int i=6; i<myString.Length; i++)
			Console.Write(myString[i]);
		Console.WriteLine();

		// Find the last 'l' in the char array
		Console.WriteLine(Array.LastIndexOf(myString, 'l'));

		// Reverse the array
		Array.Reverse(myString);
		Console.WriteLine(myString);

		// Sort the array
		Array.Sort(myString);
		Console.WriteLine(myString);
	}
}
