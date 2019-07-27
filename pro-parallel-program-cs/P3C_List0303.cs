// Isolation by Convention
using System;
using System.Threading.Tasks;

namespace Listing_0303
{
	class BankAccount {
		public int Balance { get; set; }
	}

	class Program {
		static void Main(string[] args) {

			// Create the bank account instance
			var account = new BankAccount();

			// Create an array of tasks
			var tasks = new Task<int>[10];

			for(int i = 0; i < 10; i++) {
				// Create a new task
				tasks[i] = new Task<int>((stateObject) => {
					// Get tht state object
					var isolateBalance = (int)stateObject;

					// Enter a loop for 1000 balance updates
					for( int j = 0; j < 1000; j++) {
						// update the balance
						isolateBalance++;
					}

					// return the update balance
					return isolateBalance;
				}, account.Balance);

				// start tht new task
				tasks[i].Start();
			}

			// Get the result from each task and add it to the balance
			for(int i = 0; i < 10; i++) {
				account.Balance += tasks[i].Result;
			}

			// Write out the counter value
			Console.WriteLine("Expected value {0}, Balance: {1}", 10000, account.Balance);
		}
	}
}
