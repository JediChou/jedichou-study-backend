// Listing 2-15. Sleeping by Spin Waiting
/*
	From page 29-30 >>
	Title: Using Spin Waiting
	
	The spin waiting technique is included in this chapter for completeness,
	but I recommend against using it. When you use the other two sleep tech-
	nique, the thread that is performing your task gives up its turn in the
	responsible for managing the threads running at any given time, has to 
	do some work to determine which thread should go next and make it happen.
	You can avoid the scheduler having to do this work by using a technique
	called waiting: the thread doesn't give up its turn; it just enters a 
	very tight loop on the CPU. Listing 2-15 demostrates how to perform spin
	waiting by using the Thread.SpinWait() method.
	
	<code list>
	
	The integer argument passed to the Thread.SpinWait() method is the number
	of times that the tight CPU loop should be performed, and the amount of
	time that this takes depends on the speed of your system. Spin waiting is
	most commonly used to acquire synchronization locks, which are described
	in the next chapter. The problem with spin waiting is that your task doesn't
	stop using the CPU; it just burns a specified number of CPU cycles. This
	approach distorts the behavior of the scheduling process, and you can get
	some quite odd behaviors from an application if you use spin locks wrongly.
	My advice is to avoid spin locking, because it can cause a lot more problem
	than it solves. There are very few applications that cannot rely on the
	more robust and predictable sleep techniques.
*/

using System;
using System.Threading;
using System.Threading.Tasks;

namespace Listing_15 {
	class Listing_15 {
		static void Main(string[] args) {
			// create the cancellation token source
			CancellationTokenSource tokenSource = new CancellationTokenSource();
			// create the cancellation token
			CancellationToken token = tokenSource.Token;
			
			// create the first task, which we will let run fully
			Task task1 = new Task(()=>{
				for(int i=0; i<Int32.MaxValue; i++) {
					// put the task to sleep for 10 seconds
					Thread.SpinWait(10000); // diff with book
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
			
			// cancel the token
			tokenSource.Cancel();
			
			// wait for input before exiting
			Console.WriteLine("Main method complete. Press enter to finish.");
			Console.ReadLine();
		}
	}
}
