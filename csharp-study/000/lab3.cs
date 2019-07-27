using System;

namespace lab3 {
	public class lab3 {
		public static void Main(string[] args)
		{
			///////////////////////////////////////////////////////////////////
			// <局部变量的作用域冲突>
			///////////////////////////////////////////////////////////////////
			// Compile error:
			// lab3.cs(19, 9): error CS0136:
			//   不能在此范围内声明为“j”的局部变量，因为这样会使“j”具有不同含义，
			//   而它已在“父级或当前”范围中表示其他内容了
			///////////////////////////////////////////////////////////////////
			
			int j = 20;
			for ( int i = 0; i < 10; i++)
			{
				int j = 30; // can't do this - j is still in scope
				Console.WriteLine(j + i);
			}
		}
	}
}
