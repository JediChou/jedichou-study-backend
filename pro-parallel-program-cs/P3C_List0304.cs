// Listing 3-4. Using TLS
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Listing0304
{
	class BankAccount {
		public int Balance {get; set;}
	}

	class Program
	{
		static void Main(string[] args) {
			// Define	
			var account = new BankAccount();
			var tasks = new Task<int>[10];
			var tls = new ThreadLocal<int>();

			for(int i = 0; i < 10; i++)
			{
				// create a new task
				tasks[i] = new Task<int>((stateObject)=>{
					// Get the state object and use it
					// to set the TLS data
					tls.Value = (int)stateObject;

					// enter a loop for 1000 balance updates
					for(int j = 0; j < 1000; j++) {
						// update the TLS balance
						tls.Value++;
					}

					// return the updated balance
					return tls.Value;
				}, account.Balance);

				tasks[i].Start();
			}

			// Get the result from each task and add it to the balance
			for(int i = 0; i < 10; i++) 
				account.Balance += tasks[i].Result;

			// Write out the counter value
			Console.WriteLine("Expected value {0}, Balance: {1}", 10000, account.Balance);
		}
	}
}
