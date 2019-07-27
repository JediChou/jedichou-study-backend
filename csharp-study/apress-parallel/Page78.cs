// Listing 3-14. Using declarative Synchronization
//
// Tips:
//
// So far, I have showd you how to selectively apply synchronization to
// critical regions. An alternative is to declaratively synchronize all
// of the fields and methods in a class by applying the Synchronization
// attribute. Your class must extend System.ContextBoundObject and import
// the System.Runtime.Remoting.Contexts namespace in order to be able to
// use the Synchronization attribute.
//
// To demonstrate declarative synchronization with our bank account example,
// let's change the BankAccount class so that the balance can be read with
// the GetBalance() method and incremented with the IncrementBalance()
// method, as shown in Lisitng 3-14. Now, all of the code statements are
// contained in a single class and can be be synchronized by applying the
// Synchronization attribute and having the BankAccount class extend
// ContextBoundObject.

namespace Lisitng0314 {
    
    using System;
    using System.Runtime.Remoting.Contexts;
    using System.Threading.Tasks;
    
    [Synchronization]
    class BankAccount : ContextBoundObject {
        private int balance = 0;
        
        public void IncrementBalance() {
            balance++;
        }
        
        public int GetBalance() {
            return balance;
        }
    }
    
    class Lisitng0314 {
        static void Main(string[] args) {
            
            // create the bank account instance
            BankAccount account = new BankAccount();
            
            // create an array of tasks
            Task[] tasks = new Task[10];
            
            for( int i=0; i<10; i++ ) {
                tasks[i] = new Task(()=>{
                    // enter a loop for 1000 balance updates
                    for( int j=0; j<1000; j++) {
                        // update the balance
                        account.IncrementBalance();
                    }
                });
                
                // start the task
                tasks[i].Start();
            }
            
            // wait for all of the tasks to complete
            Task.WaitAll(tasks);
            
            // write out the counter value
            Console.WriteLine("Expected value {0}, Balance: {1}",
                              10000, account.GetBalance());
                              
            // wait for input before exiting
            Console.WriteLine("Press enter to finish");
            Console.ReadLine();
        }
    }
}
