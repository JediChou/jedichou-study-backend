// Url: https://msdn.microsoft.com/zh-cn/library/system.object.referenceequals(v=vs.110).aspx

public class Example
{
	public static void Main()
	{
		int int1 = 3;
		
		// ���^ֵ��ͱ���b�䣬��t���õ��e�`�Y��
		System.Console.WriteLine(System.Object.ReferenceEquals(int1, int1));
		System.Console.WriteLine(int1.GetType().IsValueType);
	}
}
