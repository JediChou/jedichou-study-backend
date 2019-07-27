// Listing 2-16. Waiting for a Single Task
/*
	From pae 31-32 >>
	Title: Waiting for a Single Task
	
	You can wait for a single Task to complete by calling the Wait()
	instance method. The calling method will not return untl Task
	instance has completed, been cancelled or thrown an exception. See
	the next section for details of how to handle exceptions and the
	previous section for details of cancelling tasks. You can wait
	conditionally on a task by using the overloaded versions of the
	Wait() method. Table 2-6 shows the overloaded version.
	
	[Table 2-6] : overloaded versions of Task.Wait() Instance Method
	1. Wait: Wait until the Task completes, is cancelled, or throws
	   an exception.
	2. Wait(CancellationToken): Wait until CancellationToken is cancelled
	   or the Task completes, is cancelled, or throws an exception.
	3. Wait(TimeSpan): Wait until the specified TimeSpan has passed
	   or for the Task to complete, be cancelled, or throw an exception
	   (whichever happens first).
	4. Wait(Int32, CancellationToken): Wait for specified number of
	   milliseconds to pass, for the CancellationToken to be cancelled,
	   or for the Task to complete, be cancelled, or throw an exception
	   (whichever happens first).
	   
	<code list>
	
	The overloaded versions that specify a time period return a Boolean
	result, which will be true if the Task completed before the duration
	elapsed and false otherwise.
	
	Note: if an exception is throw by a Task, it will be rethrown when
	the Wait() method is called. See "Handing Exception in Tasks" section
	of this chatper for further details.
*/

using System;
using System.Threading;
using System.Threading.Tasks;

namespace Listing_16 {
	class Listing_16 {
		static void Main(string[] args) {
			// create the cancellation token source
			CancellationTokenSource tokenSource = new CancellationTokenSource();
			// create the cancellation token
			CancellationToken token = tokenSource.Token;
			
			// create and start the first task, which we will let run fully
			Task task = createTask(token);
			task.Start();
			
			// wait for the task
			Console.WriteLine("Waiting for task to complete.");
			task.Wait();
			Console.WriteLine("Task Completed.");
			
			// create and start another task
			task = createTask(token);
			task.Start();
			
			Console.WriteLine("Waiting 2 secs for task to complete.");
			bool completed = task.Wait(2000);
			Console.WriteLine("Wait ended - task completed: {0}", completed);
			
			// create and start another
			task = createTask(token);
			task.Start();
			
			Console.WriteLine("Waiting 2 secs for task to complete.");
			completed = task.Wait(2000, token);
			Console.WriteLine("Wait ended - task completed: {0} task cancelled {1}",
					completed, task.IsCanceled);
					
			// wait for input before exiting
			Console.WriteLine("Main method complete. Press enter to finish.");
			Console.ReadLine();
		}
		
		static Task createTask(CancellationToken token) {
			return new Task(() => {
				for (int i=0; i<5; i++) {
					// check for task cancellation
					token.ThrowIfCancellationRequested();
					// print out a message
					Console.WriteLine("Task - Int value {0}", i);
					// put the task to sleep for 1 second
					token.WaitHandle.WaitOne(1000);
				}
			}, token);
		}
	}
}