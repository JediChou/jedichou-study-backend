using System;

namespace lab4 {
	public class lab4 
	{
		static int j = 20;
	
		public static void Main(string[] args)
		{
			int j = 30;
			Console.WriteLine("Class level j : " + lab4.j);
			Console.WriteLine("Method level j : " + j);
			
			// 2012-12-19
			// 编译可通过, 不违反范围规则.
		}
	}
}
