namespace ProgramingCSharp4 {
	// delegate type
	public delegate void PrintDelegate();

	// Use delegate
	public class DelegateSample {
		public static void Main() {
			// anaymous method
			PrintDelegate pd = delegate {
				System.Console.WriteLine("Printing...");
			};
			pd();
		}
	}
}
