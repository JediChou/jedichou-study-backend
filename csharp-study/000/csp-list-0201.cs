using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSPList0201
{
	class Program
	{
		static void Main(string[] args)
		{
			Parallel.Invoke(
				() => ConvertEllipses(),
				() => ConvertRectangles(),
				() => ConvertLines(),
				() => ConvertText()
			);
		}

		private static void ConvertEllipses() {
			Console.WriteLine(DateTime.Now + ": 1. ConvertEllipses() ...");
		}

		private static void ConvertRectangles() {
			Console.WriteLine(DateTime.Now + ": 2. ConvertRectangles() ...");
		}

		private static void ConvertLines() {
			Console.WriteLine(DateTime.Now + ": 3. ConvertLines() ...");
		}

		private static void ConvertText() {
			Console.WriteLine(DateTime.Now + ": 4. ConvertText() ...");
		}
	}
}
