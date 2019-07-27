// Different with 070302-PointerSample2

namespace Wrox.ProCSharp.PointerSample2
{
	using System;

	// Define a struct
	struct CurrencyStruct
	{
		public long Dollars;
		public byte Cents;

		public override string ToString()
		{
			return "$" + Dollars + "." + Cents;
		}
	}

	// Define a class
	class CurrencyClass
	{
		public long Dollars;
		public byte Cents;

		public override string ToString()
		{
			return "$" + Dollars + "." + Cents;
		}
	}

	// Program start here
	class Program
	{
		public static unsafe void Main()
		{
			Console.WriteLine("Size of Currency is " + sizeof(CurrencyStruct));
			
			// Define
			CurrencyStruct amount1, amount2;
			CurrencyStruct* pAmount = &amount1;
			long* pDollars = &(pAmount->Dollars);
			byte* pCents = &(pAmount->Cents);

			// Output amount1 information
			Console.WriteLine("Address of amount1 is 0x{0:X}", (uint)&amount1);
			Console.WriteLine("Address of amount2 is 0x{0:X}", (uint)&amount2);
			Console.WriteLine("Address of pAamount is 0x{0:X}", (uint)&pAmount);
			Console.WriteLine("Address of pDollars is 0x{0:X}", (uint)&pDollars);
			Console.WriteLine("Address of pCents is 0x{0:X}", (uint)&pCents);

			pAmount->Dollars = 20;
			*pCents = 50;
			Console.WriteLine("amount1 contains " + amount1);

			// use fixed keyword to view information in the stack
			Console.WriteLine("\nNow with classes");
			var amount3 = new CurrencyClass();
			fixed(long* pDollars2 = &(amount3.Dollars))  // Notice: without tail sign -> ";"
			fixed(byte* pCents2 = &(amount3.Cents))
			{
				Console.WriteLine("amount3.Dollars has address 0x{0:X}", (uint)pDollars2);
				Console.WriteLine("amount3.Cents has address 0x{0:X}", (uint)pCents2);

				*pDollars2 = -100;
				Console.WriteLine("amount3 contains " + amount3);
			}			
		}
	}
}
