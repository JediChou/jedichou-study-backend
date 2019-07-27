// Listing 2-17. Waiting for Several Tasks
/*
	From page 33 - 34 >>>
	Title: Waiting for Several 
	
	You can wait for a number of tasks to complete by using
	static Task.WaitAll() method. This method will not return
	until of the tasks passed as arguments have completed,
	been cancelled, or thrown an exception. The WaitAll() method
	is overloaded and follows the same pattern of signatures as
	the Task.Wait() instance method (see Table 2-5 for details).
	Listing 2-17 demonstrates how to wait for several tasks.
	
	Tip : When using this method, a Task is considered complete
	if it has finished workload, been cancelled, or thrown an
	exception. If one or more of your tasks has thrown an
	exception, the WaitAll() method will throw an exception.
	See the "Handling Exceptions" section in this chapter for
	details.
	
	<code list>
*/

using System;
using System.Threading;
using System.Threading.Tasks;

namespace Listing_17 {
	class Listing_17 {
		static void Main(string[] args) {
			// create the cancellation token source
			CancellationTokenSource tokenSource = new CancellationTokenSource();
			// create the cancellation token
			CancellationToken token = tokenSource.Token;
			
			// create the tasks
			Task task1 = new Task(()=> {
				for (int i=0; i<5; i++) {
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
			Console.WriteLine("Waiting for tasks to complete.");
			Task.WaitAll(task1, task2);
			Console.WriteLine("Tasks Completed.");
			
			// wait for input before exiting
			Console.WriteLine("Main method complete. Press enter to finish.");
			Console.ReadLine();
		}
	}
}

/*
	In the listing, we create two tasks, one of which takes longer to
	complete than the other. Notice that we create cancellable tasks,
	because we want to use the CancellationToken wait handle to slow
	down the execution of the first task by putting it to sleep. We
	start both tasks and then call Task.WaitAll(), which blocks until
	both tasks are complete.
*/
