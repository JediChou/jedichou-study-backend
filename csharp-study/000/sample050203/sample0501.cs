using System.Diagnostics;
using System.Threading;
class Program {
	static void Main() {
		// Create a child process which executes the 'notepad.exe'
		// application on the text file 'hello.txt'.
		Process process = Process.Start("notepad.exe", "hello.txt");
		// Sleep one second.
		Thread.Sleep(2000);
		// Destroy the child process.
		process.Kill();
	}
}
