// ��д�����ֶ� + ������

using System;
using System.Threading;

class Mult5 {
	static bool done;
	static object locker = new object();
	static void Main() {
		new Thread (Go).Start(); Go();
	}
	static void Go() {
		lock (locker) {
			if (!done) { Console.WriteLine("Done"); done = true; }
		}
	}
}
