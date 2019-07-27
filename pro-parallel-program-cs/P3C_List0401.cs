// Listing 4-1. Task Continuation

using System;
using System.Threading.Tasks;

namespace Listing0401
{
	class BankAccount { public int Balance{get; set;} }
	class Program {
		static void Main(string[] args)
		{
			var task = new Task<BankAccount>( () => {
				// create a new bank account
				var account = new BankAccount();
				// enter a loop
				for (int i = 0; i < 1000; i++) {
					// increment the account total
					account.Balance++;
				}
				// return the bank account
				return account;
			});

			task.ContinueWith((Task<BankAccount> antecedent) => {
				Console.WriteLine("Final Balance: {0}", antecedent.Result.Balance);
			});

			// start the task
			task.Start();
		}
	}
}
