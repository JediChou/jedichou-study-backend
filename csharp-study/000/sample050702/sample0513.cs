// sample0513.cs
// how to use mutex class

using System.Threading;
using System.IO;
class Program {
	static void Main() {
		// The mutex created is named 'MutexTest'.
		Mutex mutexFile = new Mutex(false, "MutexTest");
		for( int i=0; i<10; i++) {
			mutexFile.WaitOne();
			// Open the file, write 'Hello i" and then close it.
			FileInfo fi = new FileInfo("tmp.txt");
			StreamWriter sw = fi.AppendText();
			sw.WriteLine("Hello {0}", i);
			sw.Flush();
			sw.Close();
			System.Console.WriteLine("Hello {0}", i);
			// Wait one second to make obvious the sharing of mutex.
			Thread.Sleep(1000);
			mutexFile.ReleaseMutex();
		}
		mutexFile.Close();
	}
}
