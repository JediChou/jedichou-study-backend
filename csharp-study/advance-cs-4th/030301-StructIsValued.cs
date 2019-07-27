// File name: 030391-StructIsValued.cs
// Create by Jedi at 2013.5.23 11:42 AM.
// Idea fromn <<Wrox Professional CSharp>>, zhcn-4th, Page 91
// Compile:
//   1. csc 030391-StructIsValued.cs
//   2. csc /target:exe /out:a.exe 030391-StructIsValued.cs

namespace Wrox.ProfessionalCSharp.StructIsValued {

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
		
		public double Diagonal {
			get { return Math.Sqrt(Length*Length + Width*Width); }		
		}
	}
	
	// Create a help class to test Dimensions struct.
	public class testStructIsValued
	{
		public static void Main(string[] args) {
			
			// Notice, this is other define.
			Dimensions dms;
			dms.Length = 3;
			dms.Width = 4;
			
			Console.WriteLine(dms.Diagonal);
			Console.WriteLine(typeof(Dimensions).ToString());
		}
	}
	
}
