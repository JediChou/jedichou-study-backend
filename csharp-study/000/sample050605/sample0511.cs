// File: sample0511.cs
// How to use Monitor.TryEnd() method
using System.Threading;
class Program {
	private static object staticSyncRoot = new object();
	static void Main() {
		// Comment this line to test the case where the
		// 'TryEnter()' method returns true.
		Monitor.Enter( staticSyncRoot );
		Thread t1 = new Thread(f1);
		t1.Start(); t1.Join();
	}

	static void f1() {
		if( !Monitor.TryEnter(staticSyncRoot) )
			return;

		try {
			/* ... */
		} finally {
			Monitor.Exit(staticSyncRoot);
		}
	}
}
