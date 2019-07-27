// File name: 030303-StructConstruct.cs
// Create by Jedi at 2013.5.23 14:26 PM.
// Idea fromn <<Wrox Professional CSharp>>, zhcn-4th, Page 92
// Compile:
//   1. csc 030303-StructConstruct.cs
//   2. csc /target:exe /out:a.exe 030303-StructConstruct.cs

namespace Wrox.ProfessionalCSharp.StructConstruct
{
	using System;
	
	// Create a struct. Reference by page 89.
	// This struct name is Dimensions.
	struct Dimensions
	{
		// Field define
		public double Length = 3;
		public double Width = 4;
	}
	
	/*******************************************************************************
	 * If compile, you will get this messages.
	 *******************************************************************************
	 * 030303-StructConstruct.cs(18,17): error CS0573:
	 *     'Wrox.ProfessionalCSharp.StructConstruct.Dimensions.Length': cannot have
	 *     instance field initializers in structs
	 * 030303-StructConstruct.cs(19,17): error CS0573:
	 *     'Wrox.ProfessionalCSharp.StructConstruct.Dimensions.Width': cannot have
	 *     instance field initializers in structs
	 *******************************************************************************/
}
