// 120102-GetException.cs
// From Advance c# 4th editon, page 302
// Date 2015-1-13, 15:22

using System;
namespace Wrox.ProCSharp.AdvanceCSharp
{
	public class MainEntryPoint {
		public static void Main() {
			string userInput;
			while(true) {
				try {
					Console.Write("Input a number between 0 and 5 (or return)");
					userInput = Console.ReadLine();
					
					// process
					if ( userInput == "")
						break;
					int index = Convert.ToInt32(userInput);
					if (index < 0 || index > 5)
						throw new IndexOutOfRangeException("You typed in " + userInput);
					Console.WriteLine("You number was " + index);
				}
				catch(IndexOutOfRangeException ex) {
					Console.WriteLine(
						"Exception: Number should be between 0 and 5 " +
						ex.Message);
				}
				catch(Exception ex) {
					Console.WriteLine(
						"An exception was thrown. Message was: " + ex.Message
					);
				}
				catch {
					Console.WriteLine("Some other exception has occurred");
				}
				finally {
					Console.WriteLine("Thank you");
				}
			}
		}
	}
}
