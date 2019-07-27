// 模仿前个例子，进行多线程的传参练习
using System;
using System.Threading;
class Mult9 {
	static void Main() {
		Thread t1 = new Thread(delegate() {cw("Fuck HYX");});
		Thread t2 = new Thread(delegate() {cw("Fuck Nancy again");});
		Thread t3 = new Thread(delegate() {cw(3, "Fuck Sarah again");});
		t1.Start();
		t2.Start();
		t3.Start();
	}
	static void cw(string msg) {
		Console.WriteLine("cw Method output:");
		Console.WriteLine(msg);
	}
	static void cw(int times, string msg) {
		for(int i = 0; i < times; i++)
			Console.WriteLine(msg);
	}
}
