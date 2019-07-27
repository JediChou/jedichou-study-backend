// Listing 2-12. Using the Task isCancelled Property
/*
	From page 24..25 >>
	
	You can determine if a Task has been cancelled by checking the
	IsCancelled property, which will return true if the Task was
	cancelled. Listing 2-12 demonstrates the use of this property.
	
	The code in Listing 2-12 creates two Tasks, each of which is
	constructed using CancellationToken from a different
	CancellationTokenSource. The CancellationTokenSource for the
	second Task is cancelled, but the first Task is allowed to 
	complete normally. The values of the IsCanceled property are
	printed out for each of the tasks. Running the code procedures
	results similar to the following:
	
	Command Console Output >>
	Task 1 cancelled? False
	Task 2 cancelled? True
	Task 1 - Int value 0
	...
	Task 2 - Int value 9
	Main method complete. Press enter to finish.
 */

using System;
using System.Threading;
using System.Threading.Tasks;
 
namespace Listing_12 {
	class Listing_12 {
		static void Main(string[] args) {
			
			// 1. create the cancellation token source
			// 2. create the cancellation token
			CancellationTokenSource tokenSource = new CancellationTokenSource();
			CancellationToken token1 = tokenSource.Token;
			
			// 3. create the first task, which we will let run fully
			Task task1 = new Task( () => {
				for (int i=0; i<10; i++) {
					token1.ThrowIfCancellationRequested();
					Console.WriteLine("Task 1 - Int value {0}", i);
				}
			}, token1);
			
			// 4. create the second cancellation token source
			// 5. create the cancellation token
			CancellationTokenSource tokenSource2 = new CancellationTokenSource();
			CancellationToken token2 = tokenSource2.Token;
			
			// 6. create the second task, which we will cancel.
			Task task2 = new Task( () => {
				for (int i=0; i<Int32.MaxValue; i++) {
					token2.ThrowIfCancellationRequested();
					Console.WriteLine("Task 2 - Int value {0}", i);
				}
			}, token2);
			
			// start all of the tasks
			task1.Start();
			task2.Start();
			
			// cancel the second token source
			tokenSource2.Cancel();
			
			// write out the cancellation detail of each task
			Console.WriteLine("Task 1 cancelled? {0}", task1.IsCanceled);
			Console.WriteLine("Task 2 cancelled? {0}", task2.IsCanceled);
			
			// wait for input before exiting
			Console.WriteLine("Main method complete. Press enter to finish.");
			Console.ReadLine();
		}
	}
}
 