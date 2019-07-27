using System;
using System.Threading;

public class TouPiao
{
	// 异步线程的委托定义
	public delegate int TakesAWhileDelegate(int data, int ms);

	// 异步线程的执行体:
	// 打印开始->停止指定毫秒数->打印结束->返回结果
	static int TakesAWhile(int data, int ms)
	{
		Console.WriteLine("TakesAWhile started");
		Thread.Sleep(ms);
		Console.WriteLine("TakesAWhile completed");
		return ++data;
	}

	static void Main()
	{
		// 这样是同步调用没有任何意义
		// TakesAWhile(1, 3000);
		
		// 使用异步调用必须使用委托
		TakesAWhileDelegate dl = TakesAWhile;

		// 开始进行异步调用，如果异步线程未结束则打印一个小点，然后停顿50毫秒
		IAsyncResult ar = dl.BeginInvoke(1, 5000, null, null);
		while ( !ar.IsCompleted )
		{
			// 这段内容是在主线程中执行的
			Console.Write(".");
			Thread.Sleep(50);
		}

		// 
		int result = dl.EndInvoke(ar);
		Console.WriteLine("result is {0}", result);
	}
}
