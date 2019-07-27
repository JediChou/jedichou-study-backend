// Using lamda
namespace ProgrammingCSharp4 {
	// delegate type
	public delegate string PrintDelegate(string content);

	// use delegate and lamda
	public class DelegateSample {
		public static void Main() {
			// create a delegate instance
			// and use lamda create a calculate function
			PrintDelegate pd = (str) => str += " fuck ass!";
			string result = pd("What the");
			System.Console.WriteLine(result);
		}
	}
}
