// File name: Math.cs
// Description: Generate HTML document
//   Use commmand to generate:
//   csc /t:library /doc:Math.xml MathGenDoc.cs
// Date & time: 2014-7-22 13:54

namespace Wrox.ProCSharp.Basics
{
	///<summary>
	///   Wrox.ProCSharp.Basics.Math class.
	///   Provides a method to add two integers.
	///</summary>
	public class Math
	{
		
		///<summary>
		///   The Add method allows us to add two integers
		///</summary>
		///<returns>Result of the addition (int)</returns>
		///<param name="x">First number to add</param>
		///<param name="y">Second number to add</param>
		public int Add(int x, int y)
		{
			return x + y;
		}

	}
}
