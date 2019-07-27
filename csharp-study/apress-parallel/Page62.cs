// Listing 3-6. Apply the lock Keyword
//   shows the application of the lock keyword to the critical
//   region of the bank account example from listing 3-1

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
    
    class Listing_0306 {
        static void Main(string[] args) {
        
            // create the bank account instance
            BankAccount account = new BankAccount();
           
            // create an array of tasks
            Task[] tasks = new Task[10];
           
            // create the lock object
            // 显得不是很自然. Jedi add comments.
            object lockObj = new object();
           
            for(int i=0; i<10; i++) {
                // create a new task
                tasks[i] = new Task(()=>{
                    // enter a loop for 1000 balance updates
                    for(int j=0; j<1000; j++){
                        lock(lockObj) {
                            // update the balance
                            account.Balance = account.Balance + 1;
                        }
                    }
                });
                // start the new task
                tasks[i].Start();
            }
            
            // wait for all of the tasks to complete
            Task.WaitAll(tasks);
            
            // write out the counter value
            Console.WriteLine("Expected value {0}, Balance: {1}",
                              10000, account.Balance);
                              
            // Console.WriteLine("Press enter to finish");
            Console.WriteLine("Press enter to finish");
            Console.ReadLine();
        }
    }
}
