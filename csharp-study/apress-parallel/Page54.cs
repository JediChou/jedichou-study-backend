// Listing 3-3, Isolation by Convention
// From Pro .NET 4 Parallel Programming in CSharp (2010), Page 53
// Tips:
//  We can provide a Task with isolated data by using the constructor
//  overload that takes a state object, as described in Chapter 2. Listing
//  3-3 updates our simple bank account example to use isolation. Each
//  Task is given the current balance as a state object when it is created.
//  The data is isolated because each Task only modifies its own version
//  of the balance. When all of the Tasks have completed, we read the
//  results and combin them to accurately update the bank account.

namespace Listing_03 {
    using System;
    using System.Threading.Tasks;
    
    class BankAccount {
        public int Balance {
            get;
            set;
        }
    }
    
    class Listing_03 {
        static void Main(string[] args) {
            // create the bank account instance
            BankAccount account = new BankAccount();
            
            // create an array of tasks
            Task<int>[] tasks = new Task<int>[10];
            
            for(int i=0; i<10; i++) {
                // create a new task
                tasks[i] = new Task<int>((stateObject)=>{
                    // get the state object
                    int isolatedBalance = (int)stateObject;
                    
                    // enter a loop for 1000 balance updates
                    for( int j=0; j<1000; j++) {
                        // update the balance
                        isolatedBalance++;
                    }
                    
                    // return the updated balance
                    return isolatedBalance;
                }, account.Balance);
                
                // start the task
                tasks[i].Start();
            }
            
            // get the result from each task and add it to
            // the balance
            for( int i=0; i<10; i++) {
                account.Balance += tasks[i].Result;
            }
            
            // write out the counter value
            Console.WriteLine("Expected value {0}, Balance: {1}",
                              10000, account.Balance);
                              
            // wait for input before exiting
            Console.WriteLine("Press enter to finish");
            Console.ReadLine();
        }
    }
}

/*
 * There is no data race in Listing 3-3, because the Tasks are only
 * concerned with their own local versions of the balance. This is an
 * example of <isolation by convention:> the code is written so that
 * the Tasks works in isolation but the isolation is not enforced by
 * the .NET runtime; we have to take care to ensure that Tasks don't
 * share data by mistake.
 */
