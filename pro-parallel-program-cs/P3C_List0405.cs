// Listing 4-5. A multitask continuation

using System;
using System.Threading.Tasks;

namespace Listing0405 {
	class BankAccount {
		public int Balance { get; set; }
	}

	class Program {
		static void Main(string[] args) {
			// create the bank account instance
			var account = new BankAccount();

			// create an array of tasks
			var tasks = new Task<int>[10];

			for (int i = 0; i < 10; i++) {
				// create a new task
				tasks[i] = new Task<int>( (stateObject) => {

					// get the state object
					var isolateBalance = (int)stateObject;

					// enter a loop for 10000 balance updates
					for (int j = 0; j < 1000; j++) {
						// update the balance
						isolateBalance++;
					}

					// return the update balance
					return isolateBalance;
				}, account.Balance); 
			}

			// setup a multitask continuation
			var continuation = Task.Factory.ContinueWhenAll<int>(tasks, antecedents => {
				// run through and sum the individual balances
				foreach (var t in antecedents) {
					account.Balance += t.Result;
				}
			});

			// start the atecedent tasks
			foreach (var t in tasks) {
				t.Start();
			}

			// wait for the continuation task to complete
			continuation.Wait();

			// write out the counter value
			Console.WriteLine(
				"Expected value {0}, Balance: {1}",
				10000, account.Balance
			);
		}
	}
}
