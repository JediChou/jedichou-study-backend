using System;
using System.Net;

class Program {
	static void Main() {
		try {
			var u = new Uri("http://www.foxconn.com");
		} catch (UriFormatException e) {
			Console.WriteLine(e.ToString());
		}
	}
}
