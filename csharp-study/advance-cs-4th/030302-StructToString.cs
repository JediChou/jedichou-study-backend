// File name: 030302-StructToString.cs
// Create by Jedi at 2013.5.23 13:48 PM.
// Idea fromn <<Wrox Professional CSharp>>, zhcn-4th, Page 91
// Compile:
//   1. csc 030302-StructToString.cs
//   2. csc /target:exe /out:a.exe 030302-StructToString.cs

namespace Wrox.ProfessionalCSharp.StructToString {

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
			
		public override string ToString() {
			return "Name is Dimensions";
		}	
	}
	
	// Create a help class to test Dimensions struct.
	class testStructToString
	{
		static void Main(string[] args) {
			
			// Notice, this is other define.
			Dimensions dms1; dms1.Length = 3; dms1.Width = 4;
			Dimensions dms2; dms2.Length = 3; dms2.Width = 4;
			
			// Output ToString() and equals() result.
			Console.WriteLine("dms1 ToString() result : " + dms1);
			Console.WriteLine("dms2 ToString() result : " + dms2);
			Console.WriteLine("dms1 eq dms2 result : " + dms1.Equals(dms2));
		}
	}
	
}
