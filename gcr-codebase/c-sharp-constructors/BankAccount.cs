using System;

namespace BankSystem{
   
    class BankAccount{
        public int accountNumber;        
        protected string accountHolder; 
        private double balance;         

        public BankAccount(int accNo, string holder, double bal){
            accountNumber = accNo;
            accountHolder = holder;
            balance = bal;
        }

        public double GetBalance(){
            return balance;
        }

        public void Deposit(double amount){
            balance += amount;
        }
    }
    class SavingsAccount : BankAccount{
        public SavingsAccount(int accNo, string holder, double bal)    : base(accNo, holder, bal) { }

        public void DisplayDetails(){
            Console.WriteLine("Account Number: " + accountNumber);   
            Console.WriteLine("Account Holder: " + accountHolder);  
            Console.WriteLine("Balance: " + GetBalance());          
        }
    }
     class Program{
        static void Main(){
            SavingsAccount sa = new SavingsAccount(1001, "Lei Wun", 52000);
            sa.Deposit(2000);
            sa.DisplayDetails();
        }
    }
}
