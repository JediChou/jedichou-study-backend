// File name: 030202-Overload.cs
// Create by Jedi at 2013-4-17 9:03 AM.
// Idea from <Wrox Professional CSharp>, zhcn-4th, page 80/81

namespace Wrox.ProCSharp.OverloadTest
{
	using System;

	class OverloadTestSample
	{
		// Normal overload
		public string ResultDisplay(int msg) { return "int-msg"; }
		public string ResultDisplay(string msg) { return "string-msg"; }

		// A little change
		public string OLMethod(int msg) { return "int-msg"; }
		public string OLMethod(int int_msg, string str_msg) {
			return ( OLMethod(int_msg) + "-string-msg" );
		}

		static void Main() {
			OverloadTestSample ots = new OverloadTestSample();
				
			Console.WriteLine(ots.ResultDisplay(1));
			Console.WriteLine(ots.ResultDisplay("1"));
			Console.WriteLine(ots.OLMethod(1));
			Console.WriteLine(ots.OLMethod(1,"str"));
		}
	}
}
