using System;
using System.Threading;

class Mult7 {
	static void Main() {
		// �����̵߳�ʱ����ҪThreadStart
		// �ᱻ�Զ��ƶϳ���
		var t = new Thread(Go);
		t.Start();
	}
	static void Go() {
		Console.WriteLine("This is a test for c# thread.");
	}
}
