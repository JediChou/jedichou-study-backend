// Listing 2-13. Putting a Task to Sleep
/*
	From page 26-27 >>
	Title: Using a Cancellation Token Wait Handle
	
	The best way to put Tasks to sleep is to use the wait handle
	of a CancellationToken, which you save earlier in the "Cancelling Tasks"
	section. Create an instance of CancellationTokenSource, and
	read then Token property to obtain the CancellationToken instance.
	Use the WaitHandle property, and call the overloaded WaitOne()
	method. In the "Cancelling Tasks" section, you saw the version that
	takes no arguments, which causes the calling thread to wait until
	the CancellationTokenSource.Cancel() method is called. However, 
	other overloads of this method allow you to specify a period to
	wait using either an Int32 or a TimeSpan. When you specify a time
	period, the WaitOne() method will put the task to sleep for the
	specific number of milliseconds or until the CancellationToken is
	cancelled, whichever happends first. Listing 2-13 demostrates how
	this works.
	
	<code list>
	
	Listing 2-13 creates a Task that prints out a message and then
	sleeps for 10 seconds using the WaitOne() method. If you run the
	code, the message will be printed until you hit the return key,
	at which point the CancellationToken will be cancelled, causing
	the Task to wake up again. Remember, the WaitOne() method will
	wait until either the time specified has elapsed or the token has
	been cancelled, whichever happens first. The CancellationToken.WaitOne()
	method returns true if the token has benn cancelled and false if
	the time elapsed, causing the task has woken up because the time
	specified has elapsed.
 */

using System;
using System.Threading;
using System.Threading.Tasks;

namespace Listing_13 {
	class Listing_13 {
		static void Main(string[] args) {
			// create the cancellation token source
			CancellationTokenSource tokenSource = new CancellationTokenSource();
			// create the cancellation token
			CancellationToken token = tokenSource.Token;
			
			// create the first task, which we will let run fully
			Task task1 = new Task(()=> {
				for (int i=0; i<Int32.MaxValue; i++) {
					// put the task to sleep for 10 seconds
					bool cancelled = token.WaitHandle.WaitOne(1000);  // diff with book
					// print out a message
					Console.WriteLine("Task 1 - Int value {0}. Cancelled? {1}",
						i, cancelled);
					// check to see if we have been cancelled
					if (cancelled) {
						throw new OperationCanceledException(token);
					}
				}
			}, token);
			
			// start task
			task1.Start();
			
			// wait for input before exiting
			Console.WriteLine("Press enter to cancel token.");
			Console.ReadLine();
			
			// cancel the token
			tokenSource.Cancel();
			
			// wait for input before exiting
			Console.WriteLine("Main method complete. Press enter to finish.");
			Console.ReadLine();
		}
	}
}
