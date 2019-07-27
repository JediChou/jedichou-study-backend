using System;

namespace demo {
	public static class sqlhelper {
		public static object ExecuteScalar(string sql) {
			return 1;
		}
	}

	public class Program {
		public static void Main() {
			int i = (int) sqlhelper.ExecuteScalar("");
			Console.WriteLine(i);
		}
	}
}
