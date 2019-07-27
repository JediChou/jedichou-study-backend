// Listing 3-14. Using Declarative Synchronization

using System;
using System.Runtime.Remoting.Contexts;
using System.Threading.Tasks;

namespace Listing0314 {
	
	[Synchronization]
	class BankAccount : ContextBoundObject {
		private int balance = 0;
		public void IncrementBalance() { balance++; }
		public int GetBalance() { return balance; }
	} // end BankAccount

	class Program {
		static void Main(string[] args) {
			var account = new BankAccount();
			var tasks = new Task[10];

			for(int i = 0; i < 10; i++) {
				tasks[i] = new Task( () => {
					for (int j = 0; j < 1000; j++)
						account.IncrementBalance();
				});
				tasks[i].Start();
			}

			// wait for all of the tasks to complete
			Task.WaitAll(tasks);

			// write out the counter value
			Console.WriteLine(
				"Expected value: {0}, Balance: {1}",
				10000, account.GetBalance());

		} // end program
	} // end program
}
