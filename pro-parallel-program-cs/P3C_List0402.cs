// Listing 4-2. Returning Results with Continuation Tasks

using System;
using System.Threading;
using System.Threading.Tasks;

namespace Listing0402
{
	class BankAccount { public int Balance { get; set; } }
	class Program
	{
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

			var continuationTask
				= task.ContinueWith<int>( (Task<BankAccount> antecedent) => {
					Console.WriteLine("Interim Balance: {0}", antecedent.Result.Balance);
					return antecedent.Result.Balance * 2;
				});

			// start the task
			task.Start();

			Console.WriteLine("Final balance: {0}", continuationTask.Result);
		}
	}
}
