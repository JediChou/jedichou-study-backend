using System;
[assembly : CLSCompliantAttribute(true)]
namespace CLSComplianTest {
	public class Program {
		[CLSCompliantAttribute(false)]
		public static void Fct(ushort i) { ushort j = i; }
		static void Main() {}
	}
}
