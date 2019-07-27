delegate int Mydel(int a, int b);

class Program
{
	static void Main()
	{
		Mydel del = delegate(int x, int y) { return x + y; };
		int result = del.Invoke(12, 13);
		System.Console.WriteLine(result);
	}
}
