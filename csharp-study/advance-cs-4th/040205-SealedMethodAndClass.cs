// File name: 040205-SealedMethodAndClass.cs
// Date: 2014-7-29-10-20
// Description: How to use sealed method and class.
// From Professional C# Programming 104/1220

using System;

sealed class Clingon {}
// class Laser : Clingon {}  // cannot derive from sealed type 'Clingon'

// TODO: Has a problem
class Lightor {	public sealed override int getNumbers() { return 123; } }
class Lighter : Lightor { public override int getNumbers() { return 234;} }

class Program {
	static void Main(string[] args) {
		Console.WriteLine(new Clingon().ToString());
	}
}

