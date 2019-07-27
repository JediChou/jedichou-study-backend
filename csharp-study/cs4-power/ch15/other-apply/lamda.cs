// File name: lamda.cs
// Descript: How to use delegate ?

class Program
{
	public delegate void TestDelegate(string name);
	static void Main()
	{
		TestDelegate d2 = (string name) => {
			System.Console.WriteLine("Hello, {0}", name);	
		};
		d2("Jedi");
	}
}