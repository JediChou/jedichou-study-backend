// File name: nonfunc.cs
// Description: How to use anonymous method with delegate

class Program
{
	delegate void TestDelegate(string name);
	static void Main()
	{
		TestDelegate d2 = delegate(string name) {
			System.Console.WriteLine("Hello, {0}", name);
		};
		d2("Jedi");
	}
}