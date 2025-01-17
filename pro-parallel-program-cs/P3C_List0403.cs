// Listing 4-3. Using Multiple Generations of Continuation

using System;
using System.Threading.Tasks;

namespace Listing0403
{
	class BankAccount { public int Balance { get; set; } }
	class Program
	{
		static void Main(string[] args)
		{
			var rootTask = new Task<BankAccount>( () => {
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

			// create the second-generation task, which will double
			// the antecdent balance
			var continuationTask1
				= rootTask.ContinueWith<int>( (Task<BankAccount> antecedent) => {
					Console.WriteLine("Interim Balance 1: {0}", antecedent.Result.Balance);
					return antecedent.Result.Balance * 2;
				});

			// create a third-generation task, which will print out
			// the result
			var continuationTask2
				= continuationTask1.ContinueWith( (Task<int> antecedent) => {
					Console.WriteLine("Final Balance 1: {0}", antecedent.Result);
				});

			// create a second and third-generation task in one step
			rootTask.ContinueWith<int>( (Task<BankAccount> antecedent) => {
				Console.WriteLine("Interim Balance 2: {0}", antecedent.Result.Balance);
				return antecedent.Result.Balance / 2;
			}).ContinueWith((Task<int> antecedent) => {
				Console.WriteLine("Final Balance 2: {0}", antecedent.Result);
			});

			// start the task
			rootTask.Start();
		}
	}
}
