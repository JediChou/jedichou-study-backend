// File name: 040400-IDisposeable.cs
// Date: 2014-7-31-10-23
// Description: Implement IDisposeable interface.
// From Professional C# Programming page 112/1220. 

using System;

class ImplementDispose : IDisposable {
	public void Dispose() {
		Console.WriteLine("Use Dispose method");
	}
}

class Program {
	static void Main() {
		var obj = new ImplementDispose();
	}
}
