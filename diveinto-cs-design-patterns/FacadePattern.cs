// File name : FacadePattern.cs
// Description: TODO

using System;

// Sub system. We call it is A.
class Bank
{
	public bool SufficientSavings(Customer c)
	{
		Console.WriteLine("Check bank for {0}", c.Name);
	}
}

// Sub system. We call it is B
class Credit
{
	public bool GoodCredit(int amount, Customer c)
	{
		Console.WriteLine()
	}
}
