// Listing 3-5. A TLS Value Factory That Produced Unexpected Results

namespace Listing_0305 {
    
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    
    class BankAccount {
        public int Balance {
            get;
            set;
        }
    }
    
    class Listing_0305 {
        static void Main(string[] args) {
        
            // create the bank account instance
            BankAccount account = new BankAccount();
            
            // create an array of tasks
            Task<int>[] tasks = new Task<int>[10];
            
            // create the thread local storage
            ThreadLocal<int> tls = new ThreadLocal<int>(()=>{
                Console.WriteLine("Value factory called for value: {0}",
                                  account.Balance);
                return account.Balance;
            });
            
            for(int i=0; i<10; i++) {
                // create a new task
                tasks[i] = new Task<int>(()=>{
                    // enter a loop for 1000 balance updates
                    for(int j=0; j<1000; j++) {
                        // update the TLS balance
                        tls.Value++;
                    }
                    
                    // return the updated balance
                    return tls.Value;
                });
                
                // start the new task
                tasks[i].Start();
            }
            
            // get the result from each task and add it to
            // the balance
            for(int i=0; i<10; i++) {
                account.Balance += tasks[i].Result;
            }
            
            // write out the counter value
            Console.WriteLine("Expected value {0}, Balance: {1}",
                              10000, account.Balance);
            
            // wait for input before exiting
            Console.WriteLine("Press enter to finish.");
            Console.ReadLine();
        }
    }
}

/*
 * We started then Tasks, but the value factory was called to initialize
 * the TLS only four times. Can you guess why? Yep, the code was run on a
 * four threads were used to execute the ten Tasks. As a consequence, the
 * final balance from one Task was carried over to be the initial balance
 * for another, and we ended up with an overall balance that was unexpected.
 * TLS can be a useful technique if used carefully but can trip up the 
 * unwary.
 */
