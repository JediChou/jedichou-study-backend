// Listing 3-2, An Immutable Bank Account
// From Pro .NET Parallel Programming in CSharp 2010, page 52
// Tips:
//   If sequential execution means that you get the cake to
//   yourself, immutability means that you can look at the
//   cake but can't eat. [Page 52]

using System;

namespace Listing_02 {
    class ImmutableBankAccount {
        public const int AccountNumber = 123456;
        public readonly int Balance;
        
        public ImmutableBankAccount(int InitialBalance) {
            Balance = InitialBalance;
        }
        
        public ImmutableBankAccount() {
            Balance = 0;
        }
    }
    
    class Listing_02 {
        static void Main(string[] args) {
            // create 2 bank accounts with the default balance
            ImmutableBankAccount bankAccount1 = new ImmutableBankAccount();
            ImmutableBankAccount bankAccount2 = new ImmutableBankAccount(200);
            
            // Display properties.
            Console.WriteLine("Account Number: {0}, Account Balance: {1}",
                              ImmutableBankAccount.AccountNumber, bankAccount1.Balance);
            Console.WriteLine("Account Number: {0}, Account Balance: {1}",
                              ImmutableBankAccount.AccountNumber, bankAccount2.Balance);
                              
            // wait for input before exiting
            Console.WriteLine("Press any key to finish");
            Console.ReadLine();
        }
    }
}
