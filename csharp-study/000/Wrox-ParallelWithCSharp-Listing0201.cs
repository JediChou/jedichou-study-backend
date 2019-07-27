using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing0201
{
	class Program
	{
		static void Main(String[] args)
		{
			Parallel.Invoke(
				() => ConvertEllipses(),
				() => ConvertRectangles(),
				() => ConvertLines(),
				() => ConvertText()
			);
			Console.ReadLine();
		}

		static void ConvertEllipses()
		{
			Console.WriteLine("Ellipses converted.");
		}

		static void ConvertRectangles()
	   	{
			Console.WriteLine("Rectangle converted.");
		}

		static void ConvertLines() 
		{
			Console.WriteLine("Lines converted.");
		}

		static void ConvertText() 
		{
			Console.WriteLine("Text converted.");
		}
	}
}
