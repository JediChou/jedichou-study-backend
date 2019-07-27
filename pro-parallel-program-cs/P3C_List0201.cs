/////////////////////////////////////////////////////////////////////
/// File name   : P3C_List0201.cs
/// File create : 2013-9-30 11:46 AM
/// File modify : 2013-9-30
/////////////////////////////////////////////////////////////////////
/// Description: Listing 2-1
/// Simple Console application showing the execution order problem
/// of concurrent code with Parallel.invoke
/////////////////////////////////////////////////////////////////////
/// From	- Professional Parallel Programming with C#, Page 36
/// Target	- study parallel program skill of rewrite code.
/// Auther	- Gaston C. Hillar
/// Student	- Jedi Chou
/////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing0201 {
	class Program {
		static void Main(String[] args) {
			// Use parallel invoke
			Parallel.Invoke(
				() => ConvertEllipses(),
				() => ConvertRectangles(),
				() => ConvertLines(),
				() => ConvertText());
		}

		// The first method.
		static void ConvertEllipses() {
			System.Console.WriteLine("Ellipses converted.");
		}

		// The second method.
		static void ConvertRectangles() {
			System.Console.WriteLine("Rectangles converted.");
		}

		// The third method.
		static void ConvertLines() {
			System.Console.WriteLine("Lines converted.");
		}

		// The fourth method.
		static void ConvertText() {
			System.Console.WriteLine("Text converted.");
		}
	}
}
