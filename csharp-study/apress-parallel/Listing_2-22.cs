// Listing 2-22. Custom Escalation Policy
/*
	From page 41-42
	Title: Using a Custom Escalation Policy
	
	If you don't catch AggregateException when you call a trigger
	method, the .NET Framework will escalate the exceptions. By
	default, this means that the unhandled exceptions will be thrown
	again when your Task is finalized and cause your program to be
	terminated. Because you don't know when the finalizer will be
	called, you won't be able to predict when this will happen.
	
	But, if you are determined not to handle the exceptions using
	one of the technique described in the previous sections, you 
	can override the escalation policy and supply your own code to
	call when an exception is escalated. You do this by adding an
	event to the static
	System.Threading.Tasks.TaskScheduler.UnbservedTaskException
	member, as shown in the Listing 2-22. Don't worry about the 
	other members of the TaskScheduler class; they are description
	in Chapter 4. Listing 2-22 shows how to implement an escalation
	policy that writes the exception type to the console.
	
	<code list>
*/

using System;
using System.Threading;
using System.Threading.Tasks;

namespace Listing_22 {
	class Listing_22 {
		static void Main(string[] args) {
		
			// create the new escalation policy
			TaskScheduler.UnobservedTaskException +=
				(object sender, UnobservedTaskExceptionEventArgs eventArgs) =>
				{
					// mark the exception as being handled
					eventArgs.SetObserved();
					// get the aggregate exception and process the contents
					((AggregateException)eventArgs.Exception).Handle(ex=> {
						// write the type of the exception to the console
						Console.WriteLine("Exception type: {0}", ex.GetType());
						return true;
					});
				};
				
			// create tasks that wil throw an exception
			Task task1 = new Task(()=> {
				throw new NullReferenceException();
			});
			Task task2 = new Task(()=> {
				throw new ArgumentOutOfRangeException();
			});
				
			// start the tasks
			task1.Start(); task2.Start();
				
			// wait for the tasks to complete - but do so
			// without calling any of the trigger members
			// so that the exceptions remain unhandled
			while (!task1.IsCompleted || !task2.IsCompleted) {
				Thread.Sleep(500);
			}
				
			// wait for input before exiting
			Console.WriteLine("Press enter to finish and finalize tasks");
			Console.ReadLine();
		}
	}
}

/*
	The .NET Framework calls the event handler each time an unhandled
	exception is escalated. Notice that the UnobservedTaskExceptionEve
	ntArgs.SetObserved() method is called to tell the .NET Framework 
	that the exception has been handled and should not be escalated any
	further. If you omit the call to SetObserved(), the exception will
	be escalated using the default policy. You can get the exception
	by calling the UnobservedTaskExceptionEventArgs.Excetpion property,
	which will return instances of AggregateException. See the previous
	sections for examples of how to process this type.
*/
