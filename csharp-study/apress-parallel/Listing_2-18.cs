// Listing 2-18. Using the WatiAny method
/*
	From page 34-35
	Title: Wait for One of Many Tasks
	
	The Task.WaitAny() method waits for one of a set of task
	to complete, and this method has a number of overloads,
	all of which take a Task array. The method waits until
	any of the specified Task completes and return the array
	index of the completed Task. If you use one of the overloads
	that accept additional arguments, a return value of -1
	indicates that the time period expired or the CancellationToken
	was cancelled before any of the tasks completed. Listing 2-18
	demonstrates the WaitAny() method.
	
	Tip: When using this method, a Task is considered complete
	if it finished its workload, been cancelled, or throw an
	exception. If one or more of your task has thrown an exception
	, the WaitAny() method will throw an exception. See the
	"Handling Exceptions" section in this chapter for details.
	
	<code list>
*/
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Listing_18 {
	class Listing_18 {
		static void Main(string[] args) {
		
			// create the cancellation token source
			CancellationTokenSource tokenSource = new CancellationTokenSource();
			// create the cancellation token
			CancellationToken token = tokenSource.Token;
			
			// create the tasks
			Task task1 = new Task(()=>{
				for(int i=0;i<5;i++){
					// check for task cancellation
					token.ThrowIfCancellationRequested();
					// print out a message
					Console.WriteLine("Task 1 - Int value {0}", i);
					// put the task to sleep for 1 second
					token.WaitHandle.WaitOne(1000);
				}
				Console.WriteLine("Task 1 complete");
			}, token);
			
			Task task2 = new Task(()=>{
				Console.WriteLine("Task 2 complete");
			}, token);
			
			// start the tasks
			task1.Start();
			task2.Start();
			
			// wait for the tasks
			Console.WriteLine("Waiting for task to complete.");
			int taskIndex = Task.WaitAny(task1, task2);
			Console.WriteLine("Task Completed. Index: {0}", taskIndex);
			
			// wait for input before exiting
			Console.WriteLine("Main method complete. Press enter to finish.");
			Console.ReadLine();
		}
	}
}
