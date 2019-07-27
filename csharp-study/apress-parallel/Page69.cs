// Listing 3-9.
//   Convergent Isolation with Interlocked. CompareExchange()
//
// Listing 3-9 updates the previous example so that individual
// Tasks make a note of the starting balance and work with isolated
// balance to perform their updates. When they have calculated
// their local balances, they use CompareExchange() to update
// the shared value. If the shared data has not changed, the
// account balance is updated; otherwise, a message is printed
// out. In a real program, instead of simply nothing that the
// shared data has changed, you could repeat the Task calculation
// or try a different method to update the shared data. For example,
// in the listing, we could have tried to add the local balance
// to the shared value.

namespace Listing_0309 {
    
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    
    class BankAccount {
        public int Balance = 0;
    }
    
    class Listing_0309 {
        static void Main(string[] args) {
            
            // create the bank account instance
            BankAccount account = new BankAccount();
            
            // create an array of tasks
            Task[] tasks = new Task[10];
            
            for(int i=0; i<10; i++) {
                // create a new task
                tasks[i] = new Task(()=>{
                    
                    // get a local copy of the shared data
                    int startBalance = account.Balance;
                    // create a local working copy of the shared data
                    int localBalance = startBalance;
                    
                    // enter a loop for 1000 balance updates
                    for(int j=0; j<1000; j++) {
                        // update the local balance
                        localBalance++;
                    }
                    
                    // check to see if the shared data has changed since we started
                    // and if not, then update with our local value
                    int sharedData = Interlocked.CompareExchange(
                        ref account.Balance, localBalance, startBalance);
                        
                    if (sharedData == startBalance) {
                        Console.WriteLine("Shared data updated OK");
                    } else {
                        Console.WriteLine("Shared data changed");
                    }
                });
            }
            
            // wait for all of the tasks to complete
            Task.WaitAll(tasks);
            
            // write out the counter value
            Console.WriteLine("Expected value: 10000");
            Console.WriteLine("Balance: {0}", account.Balance);
            
            // wait for input before exiting
            Console.WriteLine("Press enter to finish.");
            Console.ReadLine();
        }
    }
}

// TODO 執行發現不響應的情況。需要調試！
