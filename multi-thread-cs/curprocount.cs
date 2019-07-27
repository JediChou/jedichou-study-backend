using System;
using System.Threading;

class GetCurrentProcessorCount {
	public static void Main(string[] args) {
		// 获取当前计算机上的处理器数
		Console.WriteLine(Environment.ProcessorCount);
	}
}
