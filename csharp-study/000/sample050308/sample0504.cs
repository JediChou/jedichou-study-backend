// Main thread self kill.
// From Practical C# 2.0 and Platform, page 126
// Date: 2015-1-13, 14:38
using System;
using System.Threading;
namespace ThreadTest {
	class Program {
		static void Main() {
			Thread t = Thread.CurrentThread;
			try {
				t.Abort();
			}
			catch(ThreadAbortException) {
				Thread.ResetAbort();
			}
		}
	}
}
