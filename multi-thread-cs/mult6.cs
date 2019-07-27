using System;
using System.Threading;

namespace Mult6 {
	class Mult6 {
		static void Main() {
			var t = new Thread(new ThreadStart(Go));
			t.Start();
			Go();
		}
		static void Go() {
			Console.WriteLine("Hello!");
		}
	}
}
