// File name: 030602-CheckToString.cs
// Description: How to override ToString method.
// Create by Jedi at 2014.7.25 11:09 AM.
// Idea fromn <<Wrox Professional CSharp>>, zhcn-4th, Page 96
// Compile:
//   1. csc 030602-CheckToString.cs
//   2. csc /target:exe /out:a.exe 030303-StructConstruct.cs

using System;

namespace Wrox.ProfessionalCSharp.ObjectToString
{
	class MainEntryPoint
	{
		static void Main(string[] args)
		{
			var cash1 = new Money();
			cash1.Amount = 40M;
			Console.WriteLine("cash1.ToString() returns:" + cash1.ToString());
		}
	}

	class Money
	{
		private decimal amount;

		public decimal Amount
		{
			get { return amount; }
			set { amount = value; }
		}

		public override string ToString()
		{
			return "$"+Amount.ToString();
		}
	}
}
