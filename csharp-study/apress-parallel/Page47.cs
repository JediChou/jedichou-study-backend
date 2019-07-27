// Listing. Page47.cs
/*
    From page 46-47
	Title:
	1. Excessive Spinning
	2. Solution
	3. Example
    
    Excessive Spinning
    Many programmers overestimate the performance impact of a Task
    waiting (either via Thread.Sleep() or by using a CancellationToken
    wait handle) and use spin waiting instead (through the Thread.SpinWait()
    method or by entering a code loop).
    
    For anything other than exceptionally short waits, spin waiting
    and code loops will cripple the performance of your parallel program,
    because avoiding a wait also avoids freeing up a thread for execution.
    
    Solution
    Restrict your use of spin waiting and code loops to situations where
    you know that the condition that you are waiting for will take only
    a few CPU cycles. If you must avoid a full wait, use spin waiting in
    preference to code loops.
    
    Example
    In the following example, one Task enters a code loop to await the
    cancellation of another Task. Another Task does the same thing but
    uses spin waiting. On the quad-core machine that I used to write this
    book, this example burns roughly 30 percent of the available CPU, which
    is quite something for a program that does nothing at all. You may
    get different results if you have fewer cores.
*/

using System;
using System.Threading;
using System.Threading.Tasks;

namespace Excessive_Spinning {
    class Excessive_Spinning {
        static void Main(string[] args) {
            // create a cancellation token source
            CancellationTokenSource tokenSource =
                new CancellationTokenSource();
            
            // create the first task
            Task t1 = Task.Factory.StartNew(()=>{
                Console.WriteLine("Task 1 waiting for cancellation");
                tokenSource.Token.WaitHandle.WaitOne();
                Console.WriteLine("Task 1 cancelled");
                tokenSource.Token.ThrowIfCancellationRequested();
            }, tokenSource.Token);
            
            // create the second task, which will use a code loop
            Task t2 = Task.Factory.StartNew(()=>{
                // enter a loop until t1 is cancelled
                while(!t1.Status.HasFlag(TaskStatus.Canceled)) {
                    // do nothing - this is a code loop
                }
                Console.WriteLine("Task 2 exited code loop");
            });
            
            // create the third loop which will use spin waiting
            Task t3 = Task.Factory.StartNew(()=>{
                // enter the spin wait loop
                while(t1.Status != TaskStatus.Canceled) {
                    Thread.SpinWait(1000);
                }
                Console.WriteLine("Task 3 exited spin wait loop");
            });
            
            // prompt the user to hit enter to cancel
            Console.WriteLine("Press enter to cancel token");
            Console.ReadLine();
            tokenSource.Cancel();
            
            // wait for input before exiting
            Console.WriteLine("Main method complete. Press enter to finish.");
            Console.ReadLine();
        }
    }
}
