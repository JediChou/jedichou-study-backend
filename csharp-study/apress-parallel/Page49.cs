// Listing 3-1. Hello Task
// From Apress - Pro .NET 4 Parallel Programming in CSharp (2010), page 49.

using System;
using System.Threading.Tasks;

namespace Listing_01 {
    class BankAccount {
        public int Balance {
            get;
            set;
        }
    }
    
    class Listing_01 {
        static void Main(string[] args) {
            // create the bank account instance
            BankAccount account = new BankAccount();
            
            // create an array of tasks
            Task[] tasks = new Task[10];
            
            for(int i = 0; i < 10; i++) {
                // create a new task
                tasks[i] = new Task(()=>{
                    // enter a loop for 1000 balance updates
                    for(int j=0; j<1000; j++) {
                        // update the blance
                        account.Balance = account.Balance + 1;
                    }
                });
                
                // start the new task
                tasks[i].Start();
            }
            
            // wait for all of the tasks to complete
            Task.WaitAll(tasks);
            
            // write out the counter value
            Console.WriteLine("Expected value {0}, Counter value: {1}",
                              10000, account.Balance);
            
            // wait for input before exiting
            Console.WriteLine("Press enter to finish");
            Console.ReadLine();
        }
    }
}

/*
 * The Trouble with Data
 * Listing 3-1 creates ten Tasks, each of which increments the
 * BankAccount.Balance propertly 1000 times. We wait for all of
 * the Task to complete and print out the value of Balance. If 
 * there are ten Tasks and each of them increments Balance 1000
 * times, the final value of Balance should be 10000. Running
 * Listing 3-1 might produce the following results:
 *    Expected value 100000, Balance: 8840
 *    Press any key to continue ...
 */
