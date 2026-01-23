using System;

class InsufficientFunds : Exception
{
    public InsufficientFundsException(string message) : base(message) { }
}

class BankAccount
{
    double balance = 5000;

    public void Withdraw(double amount)
    {
        if (amount < 0)
            throw new ArgumentException("Invalid amount!");

        if (amount > balance)
            throw new InsufficientFundsException("Insufficient balance!");

        balance -= amount;
        Console.WriteLine("Withdrawal successful, new balance: " + balance);
    }

    static void Main()
    {
        BankAccountAlgo account = new BankAccountAlgo();

        try
        {
            Console.Write("Enter withdrawal amount: ");
            double amount = double.Parse(Console.ReadLine());

            account.Withdraw(amount);
        }
        catch (InsufficientFundsException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
