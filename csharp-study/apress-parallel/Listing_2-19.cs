// Listing 2-19. Basic Exception Handling
/*
	From page 36-37
	Title: Handling Basic Exceptions
	
	Any exception that is thrown (and not caught) by a Task is squirreled
	away by the .NET Framework until you call a trigger memeber, such as
	Task.Wait(), Task.WaitAny(), or Task.Result, at which point the trigger
	member will throw an instance of System.AggregateException.
	
	The AggregateExcetpion type is use to provide a wrpper around one or
	more exceptions, and this is useful because methods such as WaitAll()
	coordinate multiple Tasks and may need to present you with mulitple
	exception. This feature is also useful for Task chaing, which is described
	in the next chapter. An AggregateExeption is always thrown by the
	trigger methods, even when there has been only one exception thrown.
	
	An example is always the best illustration, so Listing 2-19 creates
	three Tasks, two of which throw exception. The main thread starts the
	tasks and then calls static WaitAll() method, catches the AggregateException
	and prints out details of the exceptions thrown by the individual Tasks.
	
	<code list>
*/

using System;
using System.Threading;
using System.Threading.Tasks;

namespace Listing_19 {
	class Listing_19 {
		static void Main(string[] args) {
			
			// create the tasks
			Task task1 = new Task(()=>{
				ArgumentOutOfRangeException exception = new ArgumentOutOfRangeException();
				exception.Source = "task1";
				throw exception;
			});
			Task task2 = new Task(()=>{
				throw new NullReferenceException();
			});
			Task task3 = new Task(()=>{
				Console.WriteLine("Hello from Task 3");
			});
			
			// start the tasks
			task1.Start();
			task2.Start();
			task3.Start();
			
			// wait for all of the tasks to complete
			// and wrap the method in a try...catch block
			try{
				Task.WaitAll(task1, task2, task3);
			} catch (AggregateException ex) {
				// enumerate the exceptions that have been aggregated
				foreach(Exception inner in ex.InnerExceptions) {
					Console.WriteLine("Exception type {0} from {1}",
						inner.GetType(), inner.Source);
				}
			}
			
			// wait for input before exiting
			Console.WriteLine("Main method complete. Press enter to finish.");
			Console.ReadLine();
		}
	}
}

/*
	To get the exception that have been aggregated, you call the
	InnerExceptions property of AggregateException, which returns
	a collections of exceptions that you can enumerate.
	
	In the listing, tasks task1 and task2 throw exceptions, which
	are bundled up into an instance of AggregateException. This
	exception is thrown when we call the Task.WaitAll() trigger
	method. One shortcoming of this approach to handling exceptions
	is that there is no obvious way of correlating exceptions that
	have been thrown to the task that threw them. In the code listing,
	the Exception.Source property is used to indicate that task1 is
	the source of the ArgumentOutOfRangeException.
*/
