using System;

namespace MyApp
{
    public class BankAccount
    {
        private double balance;

        public void Deposit(double amount)
        {
            if (amount < 0)
                throw new ArgumentException("Deposit amount cannot be negative");

            balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount < 0)
                throw new ArgumentException("Withdrawal amount cannot be negative");

            if (amount > balance)
                throw new InvalidOperationException("Insufficient funds");

            balance -= amount;
        }

        public double GetBalance()
        {
            return balance;
        }
    }
}
