// Listing 2-9. Cancelation Monitoring with a Wait Handle

using System;
using System.Threading;
using System.Threading.Tasks;

namespace Listing_09 {
	class Listing_09 {
		static void Main(string[] args) {
			
			// create the cancellation source
			CancellationTokenSource tokenSource
				= new CancellationTokenSource();
				
			// creat the cancellation token
			CancellationToken token = tokenSource.Token;
			
			// create the task
			Task task1 = new Task( () => {
				for (int i=0; i<Int32.MaxValue; i++) {
					if (token.IsCancellationRequested) {
						Console.WriteLine("Task cancel detected");
						throw new OperationCanceledException(token);
					} else {
						Console.WriteLine("Int value is {0}", i);
					}
				}
			}, token);
			
			// create a second task that will use the wait handle
			Task task2 = new Task( () => {
				// wait on the handle
				token.WaitHandle.WaitOne();
				// write out a message
				Console.WriteLine(">>>>> Wait handle released");
			});
			
			// wait for input before we start the task
			Console.WriteLine("Press enter to start task");
			Console.WriteLine("Press enter again to cancel task");
			Console.ReadLine();
			
			// start task
			task1.Start();
			task2.Start();
			
			// read a line from the console.
			Console.ReadLine();
			
			// cancel the task
			Console.WriteLine("cancelling task");
			tokenSource.Cancel();
			
			// wait for input before exiting
			Console.WriteLine("Main method complete. Press enter to finish.");
			Console.ReadLine();
		}
	}
}
