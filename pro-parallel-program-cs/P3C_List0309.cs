// Listing 3-9. Convergent Isolation with Interlocked.CompareExchange()

using System;
using System.Threading;
using System.Threading.Tasks;

namespace Listing0309 {
	class BankAccount { public int Balance = 0; }

	class Program {
		static void Main(string[] args) {
			var account = new BankAccount();
			var tasks = new Task[10];

			for(int i = 0; i < 10; i++) {
				// create a new task
				tasks[i] = new Task( () => {
					var startBalance = account.Balance;
					var localBalance = startBalance;

					for(int j = 0; j< 1000; j++)
						localBalance++;

					// check to see if the shared data has changed
					// since we started and if not, then update with
					// our local value
					var sharedData = Interlocked.CompareExchange(
						ref account.Balance, localBalance, startBalance
					);

					if( sharedData == startBalance )
						Console.WriteLine("Shared data updated OK");
					else
						Console.WriteLine("Shared data changed");
				});

				// start the new task
				tasks[i].Start();
			}

			// wait for all of the tasks to complete
			Task.WaitAll(tasks);

			// Write out the counter value
			Console.WriteLine("Expected value: {0}, Balance:{1}",
				10000, account.Balance);
		}
	}
}
