// Listing 2-20. Using an Iterative Exception Handler
/*
	From page 37 - 39
	Title : Using an Iterative Handler
	
	Generally, you will need to differentiate between the exception
	that you were expecting and the ones that are unexpected and you
	need to propagate. The AggregateExcetpion class provides the
	Handle() method, which allows you to specify a function delegate
	that will be called for each exception. Your function or lambda
	expression should return true if the exception is one that you
	can handle and false otherwise.
	
	The "Cancelling Tasks" section of this chapter explaind that you
	should throw an instance of the OperationCanceledException to 
	acknowledge cancellation request. That type of exception is likely
	to be one you have to process most frequently. Listing 2-20 shows
	you how to use the AggregateException.Handle() method to differentiate
	between an exception thrown for a cancellation and other kinds of
	exception.
	
	<code list>
	
*/

using System;
using System.Threading;
using System.Threading.Tasks;

namespace Listing_20 {
	class Listing_20 {
		static void Main(string[] args) {
		
			// create the cancellation token source and the token
			CancellationTokenSource tokenSource = new CancellationTokenSource();
			// create the canellation token
			CancellationToken token = tokenSource.Token;
			
			// create a task that waits on the cancellation token
			Task task1 = new Task(()=>{
				// wait forever or until the token is cancelled
				token.WaitHandle.WaitOne(-1);
				// throw an exception to acknowledge the cancellation
				throw new OperationCanceledException(token);
			}, token);
			
			// create a task that throws an exception
			Task task2 = new Task(()=> {
				throw new NullReferenceException();
			});
			
			// start the tasks
			task1.Start();
			task2.Start();
			
			// cancel the token
			tokenSource.Cancel();
			
			// wait on the tasks and catch any exceptions
			try{
				Task.WaitAll(task1, task2);
			} catch (AggregateException ex) {
				// iterate through tht inner exceptions using
				// the handle method
				ex.Handle((inner)=> {
					if (inner is OperationCanceledException) {
						// ...handle task cancellation...
						return true;
					} else {
						// this is an exception we don't know how
						// to handle, so return false
						return false;
					}
				});
			}
			
			// wait for input before exiting
			Console.WriteLine("Main method complete. Press enter to finsish.");
			Console.ReadLine();
		}
	}
}

/*
	If you compile and run the code in Listing 2-20, you will see
	one of the exceptions --- NullReferenceException --- being reported
	as unhandled. This is, of course, because the exception handler
	only marks OperationCanceledExceptions as handled.
*/

/*
	Lab comment
	1. compile and run it, I get a run time error.
	2. and vsts 2010 will pop a debug window.
	3. VSTS IntelliTrace
	  Debugger: Step Recorded: Main, Program.cs line 13
	  Exception: Thrown: "Object reference not set to an instance of an object." (System.NullReferenceException)
	  A System.NullReferenceException was throw:"Object referecne not set to an instance of an object."
	  Thread: <No Name> [4392] Related views: Locals, call stack, Exception Settings
	4. Must execute under XP that has not IDE supported.
	
*/
