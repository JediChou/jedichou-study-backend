// Listing 3-5. A TLS Value Factory That Produced Unexpected Results

using System;
using System.Threading;
using System.Threading.Tasks;

namespace Listing0305
{
	class BankAccount {
		public int Balance {get; set;}
	}

	class Program {
		static void Main(string[] args) {
			
			// Create the bank account instance
			var account = new BankAccount();

			// Create an array of tasks
			var tasks = new Task<int>[10];

			// Create the thread local storage
			var tls = new ThreadLocal<int>( ()=> {
				Console.WriteLine("Value factory called for value: {0}",
					account.Balance);
				return account.Balance;
			});

			for(int i=0; i<10; i++)
			{
				// Create a new task
				tasks[i] = new Task<int>(()=>{
					// Enter a loop for 10000 balance updates
					for(int j=0; j<1000; j++)
						tls.Value++;
					return tls.Value;
				});
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
