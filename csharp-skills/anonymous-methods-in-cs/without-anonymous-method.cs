delegate int Mydel(int a, int b);

class Program
{
	public static int Add(int x, int y)
	{
		int sum = x + y;
		return sum;
	}

	static void Main()
	{
		Mydel obj = Add;
		int result = obj.Invoke(12, 13);
		System.Console.WriteLine("The sum is : {0}", result); 
	}
}
