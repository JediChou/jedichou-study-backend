// Listing 2-21. Exception Handling with Task Properties
/*
	From page 39-41
	Title : Reading the Task Properties
	
	An alternative to catching the exception is to use the properties
	of the Task class, in particular, the IsCompleted, IsFaulted, IsCancelled, 
	and Exception properties. You still have no catch AggregateException
	when you call any of the trigger methods, but you can use the properties
	to determine if a task has completed, thrown an exception, or been
	cancelled, and if an exception was thrown, you can get the details of
	the exception. Listing 2-21 shows you how to use the Task properties.
	
	<code list>
	
*/

using System;
using System.Threading;
using System.Threading.Tasks;

namespace Listing_21 {
	class Listing_21 {
	
		static void Main(string[] args) {
			CancellationTokenSource tokenSource = new CancellationTokenSource();
			
			// create a task that throws an exception
			Task task1 = new Task(()=> {
				throw new NullReferenceException();
			});
			
			Task task2 = new Task(()=> {
				// wait until we are cancelled
				tokenSource.Token.WaitHandle.WaitOne(-1);
				throw new OperationCanceledException();
			}, tokenSource.Token);
			
			// start the tasks
			task1.Start();
			task2.Start();
			
			// cancel the token
			tokenSource.Cancel();
			
			// wait for the tasks, ignoring the exceptions
			try {
				Task.WaitAll(task1, task2);
			} catch (AggregateException) {
				// ignore exceptions
			}
			
			// write out the details of the task exception
			Console.WriteLine("Task 1 completed: {0}", task1.IsCompleted);
			Console.WriteLine("Task 1 faulted: {0}", task1.IsFaulted);
			Console.WriteLine("Task 1 cancelled: {0}", task1.IsCanceled);
			Console.WriteLine(task1.Exception);
			
			// write out the details of the task exception
			Console.WriteLine("Task 2 completed: {0}", task2.IsCompleted);
			Console.WriteLine("Task 2 faulted: {0}", task2.IsFaulted);
			Console.WriteLine("Task 2 cancelled: {0}", task2.IsCanceled);
			Console.WriteLine(task2.Exception);
			
			// wait for input before exiting
			Console.WriteLine("Main method complete. Press enter to finish.");
			Console.ReadLine();
		}
	}
}

/*
	The code in the listing creates two tasks: one throws an exception,
	and the other waits for a CancellationToken to be cancelled. Once the
	tasks are started, we cancel the token and call Task.WaitAll() to allow
	the tasks to complete. We ignore any exception by catching and discarding
	AggregateException and then print the values of the Task properties to
	the console, geting the following results:
	
	The IsCompleted property will return true if the Task has completed
	and false otherwise. The IsFaulted property returns true if the Task
	has thrown an exception and false if it has not or if the Task has been
	cancelled. The IsCanceled property returns true if the Task has been
	cancelled.
*/
