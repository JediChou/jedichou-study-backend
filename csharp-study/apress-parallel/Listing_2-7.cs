// Listing 2-7. Cancelling a Task

using System;
using System.Threading;
using System.Threading.Tasks;

namespace Listing_07
{
	class Listing_07
	{
		static void Main(string[] args)
		{
			// create the cancellatin token source
			CancellationTokenSource tokenSource
				= new CancellationTokenSource();
				
			// create the cancellation token
			CancellationToken token = tokenSource.Token;
			
			// create the task
			Task task = new Task( () => {
				for (int i=0; i<int.MaxValue; i++) {
					if (token.IsCancellationRequested) {
						Console.WriteLine("Task cancel detected");
						throw new OperationCanceledException(token);
					} else {
						Console.WriteLine("Int value {0}", i);
					}
				}
			}, token);
			
			// wait for input before we start the task
			Console.WriteLine("Press enter to start task");
			Console.WriteLine("Press enter again to cancel task");
			Console.ReadLine();
			
			// start the task
			task.Start();
			
			// read a line from the console.
			Console.ReadLine();
			
			// cancel the task
			Console.WriteLine("Cancel task");
			tokenSource.Cancel();
		}
	}
}
