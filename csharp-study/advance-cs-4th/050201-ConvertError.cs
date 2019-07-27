namespace Wrox.ProCSharp.ConvertError {
	class Program {
		static void Main() {
			byte value1 = 10, value2 = 23;
			byte total;
			total = value1 + value2;
			// Error message: 
			// Cannot implicitly convert type 'int' to 'byte'. An
			// explicit conversion exists (are you missing a cast?)
		}
	}
}
