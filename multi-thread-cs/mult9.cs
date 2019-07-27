// file name: mult9.cs
// 将数据传入ThreadStart中
using System;
using System.Threading;
class Mult9 {
	static void Main() {
		Thread t = new Thread(Go);
		t.Start(true);
		Go(false);
	}
	static void Go (object upperCase) {
		bool upper = (bool) upperCase;
		Console.WriteLine(upper ? "HELLO!" : "hello!");
	}
}
