// File name: 040401-DefineAndUseInterface.cs
// Date: 2014-7-31-13-03
// Description: Define and implement C# interface.
// From Professional C# Programming, 113/1220

using System;

namespace Wrox.ProCSharp.UseInterface
{
	// IBankAccount Interface
	public interface IBankAccount
	{
		void PayIn(decimal amount);
		bool WithDraw(decimal amount);
		decimal Balance { get; }
	}

	// Implement interface
	public class SaverAccount : IBankAccount
	{
		// Define a banlance field
		private decimal balance;

		// Implement interface method
		public void PayIn(decimal amount) {
			balance += amount;
		}

		// Implement interface method
		public bool WithDraw(decimal amount) {
			if(balance >= amount) {
				balance -= amount;
				return true;
			}
			Console.WriteLine("Withdrawal attemp failed.");
			return false;
		}

		// Implement interface property
		public decimal Balance {
			get { return balance; }
		}

		// Override ToString()
		public override string ToString() {
			return String.Format("Venus Bank Saver: Balance = {0,6:c}", balance);
		}
	}

	public class Program
	{
		static void Main(string[] args)
		{
			var venus = new SaverAccount();
			venus.PayIn(200);
			venus.WithDraw(100);
			Console.WriteLine(venus.ToString());
		}
	}
}
