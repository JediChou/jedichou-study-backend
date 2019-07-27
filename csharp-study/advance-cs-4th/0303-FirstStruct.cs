// File name: 0303-FirstStruct.cs
// Create by Jedi at 2013.5.23 11:42 AM.
// Idea fromn <<Wrox Professional CSharp>>, zhcn-4th, Page 89
// Compile:
//   1. csc 0303-FirstStruct.cs
//   2. csc /target:exe /out:a.exe 0303-FirstStruct.cs

namespace Wrox.ProfessionalCSharp.FirstStruct {

	using System;
	using System.Collections.Generic;
	
	// Create a struct. Reference by page 89.
	// This struct name is Dimensions.
	struct Dimensions
	{
		// Field define
		public double Length;
		public double Width;
		
		// Construct
		Dimensions(double length, double width) {
			Length = length;
			Width = width;
		}
		
		// Jedi: What this ?
		// Simulate a class property.
		public double Diagonal {
			get { return Math.Sqrt(Length*Length + Width*Width); }		
		}
	}
	
	// Create a help class to test Dimensions struct.
	public class testFirstStruct
	{
		public static void Main(string[] args) {
			Dimensions dms = new Dimensions();
			dms.Length = 3;
			dms.Width = 4;
			
			Console.WriteLine(dms.Diagonal);
		}
	}
	
}
