// File name: 030202-PropertyOnlyreadTest.cs
// Create by Jedi at 2013.4.17 10:40 AM.
// Idea from <Wrox Professional C#>, zhcn-4th, Page 82

namespace Wrox.ProfessionalCSharp.PropertyOnlyread
{
	using System;

	class PropertyOnlySample
	{
		private string name;
		public string Name
		{
			set { name = value; }
			get { return name; }
		}

		// ============================================================
		// If comment set { name = value; }, will get
		// ============================================================
		// 030202-PropertyOnlyreadTest.cs(24,4): error CS0200: Property
		// or indexer 'Wrox.ProfessinoalCSharp.PropertyOnlyread.
		// PropertyOnlySample.Name' cannot be assigned to -- it is read
		// only
		// ============================================================
	}

	class PropertyOnlySampleTest
	{
		static void Main()
		{
			PropertyOnlySample pos = new PropertyOnlySample();
			pos.Name = "Jedi";
			Console.WriteLine(pos.Name);
		}
	}
}
