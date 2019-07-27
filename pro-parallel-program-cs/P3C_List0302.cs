using System;

namespace Listing_0302
{
	class ImmutableBankAccount {
		public const int AccountNumber = 123456;
		public readonly int Balance;

		public ImmutableBankAccount(int InitialBalance) {
			Balance = InitialBalance;
		}

		public ImmutableBankAccount() {
			Balance = 0;
		}
	}

	class Listing_0302
	{
		static void Main(string[] args) {
			
			// Create a bank account with the default balance
			var bankAccount1 = new ImmutableBankAccount();
			Console.WriteLine("Account Number: {0}, Account Balance: {1}",
				ImmutableBankAccount.AccountNumber, bankAccount1.Balance);

			// Create a bank account with a starting balance
			var bankAccount2 = new ImmutableBankAccount(200);
			Console.WriteLine("Account Number: {0}, Account Balance: {1}",
				ImmutableBankAccount.AccountNumber, bankAccount2.Balance);	
		}
	}
}
