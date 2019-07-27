// File name: 040402-InterfaceFromInterface.cs
// Date: 2014-10-16-12-04
// Description: Interface from interface
// From Professional C# Programming, 116/143

namespace Wrox.ProCSharp.IFI {
	
	using System;

	// IBankAccount Interface
	public interface IBankAccount {
		void PayIn(decimal amount);
		bool WithDraw(decimal amount);
		decimal Balance { get; }
	}

	// ITtransferBankAccount interface
	public interface ITtransferBankAccount : IBankAccount {
		bool TransferTo(IBankAccount destination, decimal amount);
	}

	// SaverAccount
	class SaverAccount : IBankAccount
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

	// CurrentAccount
	class CurrentAccount : ITtransferBankAccount {
		private decimal balance;

		public void PayIn(decimal amount) {
			balance += amount;
		}

		public bool WithDraw(decimal amount) {
			if (balance >= amount) {
				balance = amount;
				return true;
			}
			Console.WriteLine("Withdrawal attempt failed.");
			return false;
		}

		public decimal Balance { get {return balance;} }

		public bool TransferTo(IBankAccount destination, decimal amount) {
			bool result;
			if ( (result = WithDraw(amount)) == true)
				destination.PayIn(amount);
			return result;
		}

		public override string ToString() {
			return String.Format(
				"Jupiter Bank Current Accmount: Balance = {0,6:C}",
				balance
			);
		}
	}

	public class Program {
		public static void Main(string[] args) {
			var venusAccount = new SaverAccount();
			var jupiterAccount = new CurrentAccount();
			
			venusAccount.PayIn(200);
			jupiterAccount.PayIn(500);
			jupiterAccount.TransferTo(venusAccount, 100);
			
			Console.WriteLine(venusAccount);
			Console.WriteLine(jupiterAccount);
		}
	}
}
