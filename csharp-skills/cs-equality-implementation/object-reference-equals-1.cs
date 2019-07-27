// Url: https://msdn.microsoft.com/zh-cn/library/system.object.referenceequals(v=vs.110).aspx

public class Example
{
	public static void Main()
	{
		int int1 = 3;
		
		// 比較值類型必須裝箱，否則會得到錯誤結果
		System.Console.WriteLine(System.Object.ReferenceEquals(int1, int1));
		System.Console.WriteLine(int1.GetType().IsValueType);
	}
}
