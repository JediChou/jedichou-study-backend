// Listing. Page46.cs
/*
	From page 46-47
	Title:
	1. Local Variable Evaluation
	2. Solution
	3. Example
	
	Local Variable Evaluation
    Assume that you create a series of Task in a for loop and refer to the
    loop counter in your lambda expressions. All of the Tasks end up with
    the same value because of the way that the C# variable scoping rules are
    applied to lambda expressions.
    
    Solution
    The simplest way to fix this problem is to pass the loop counter in as
    a state to the Task.
    
    Example
    In the following example, five Tasks print out a message that reference
    the counter of the loop that created them, and they all print the same
    value. Another five Tasks do the same thing, but get their values as state
    objects, and these get the expected values.
*/

using System;
using System.Threading.Tasks;

namespace Local_Variable_Evaluation {
    class Local_Variable_Evaluation {
        static void Main(string[] args) {
            // create and start the "bad" tasks
            for(int i=0; i<5; i++) {
                Task.Factory.StartNew(()=>{
                    // write out a message that uses the loop counter
                    Console.WriteLine("Task {0} has counter value: {1}",
                        Task.CurrentId, i);
                });
            }
            
            // create and start the "good" tasks
            for(int i=0; i<5; i++) {
                Task.Factory.StartNew((stateObj)=>{
                    // cast the state object to an int
                    int loopValue = (int)stateObj;
                    // write out a message that uses the loop counter
                    Console.WriteLine("Task {0} has counter value: {1}",
                        Task.CurrentId, loopValue);
                }, i);
            }
            
            // wait for input before exiting
            Console.WriteLine("Main method complete. Press enter to finished");
            Console.ReadLine();
        }
    }
}
