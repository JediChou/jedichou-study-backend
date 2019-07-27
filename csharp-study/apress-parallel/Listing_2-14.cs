// Listing 2-14. Sleeping Using Classic Threads
/*
	From page 27-28 >>
	Title: Using Classic Sleep
	
	Because the TPL uses the classic .NET threading support behind
	the scenes, you can use the classic threading technique to put
	a Task to sleep. Call the static Thread.Sleep() method, and
	pass a time interval as an argument. Listing 2-14 reworks the
	previous example to use this technique.
	
	<code list>
	
	The key difference with this technique is that cancelling the
	token doesn't immediately cancel the task, because the Thread.sleep()
	method will block the time specified has elapsed and only then
	check the cancellation status. In this simple example, this
	means that the task continues to exist, albeit asleep, for up
	to 10 seconds after the token has been cancelled.
*/

using System;
using System.Threading;
using System.Threading.Tasks;

namespace Listing_14 {
	class Listing_14 {
		static void Main(string[] args) {
			// create the cancellation token source
			CancellationTokenSource tokenSource = new CancellationTokenSource();
			// create the cancellation token
			CancellationToken token = tokenSource.Token;
			
			// create the first task, which we will let run fully
			Task task1 = new Task(()=>{
				for(int i=0; i<Int32.MaxValue; i++) {
					// put the task to sleep for 1 seconds
					Thread.Sleep(1000); // diff with book
					// print out a message
					Console.WriteLine("Task 1 - Int value {0}", i);
					// check for task cancellation
					token.ThrowIfCancellationRequested();
				}
			}, token);
			
			// start task
			task1.Start();
			
			// wait for input before exiting
			Console.WriteLine("Press enter to cancel token.");
			Console.ReadLine();
			
			// cancel the token();
			tokenSource.Cancel();
			
			// wait for input before exiting
			Console.WriteLine("Main method complete. Press enter to finish.");
			Console.ReadLine();
		}
	}
}
