using System;

class BankAccount{
    public int accNo;
    public double balance;

    public BankAccount(int accNo, double balance){
        this.accNo = accNo;
        this.balance = balance;
    }
}

class SavingsAccount : BankAccount{
    public double rate;

    public SavingsAccount(int accNo, double balance, double rate): base(accNo, balance){
        this.rate = rate;
    }

    public void DisplayAccountType(){
        Console.WriteLine("Savings Account");
    }
}

class CheckingAccount : BankAccount{
    public double limit;

    public CheckingAccount(int accNo, double balance, double limit): base(accNo, balance){

        this.limit = limit;
    }

    public void DisplayAccountType(){
        Console.WriteLine("Checking Account");
    }
}

class FixedDepositAccount : BankAccount{
    public int years;

    public FixedDepositAccount(int accNo, double balance, int years): base(accNo, balance){
        this.years = years;
    }

    public void DisplayAccountType(){
        Console.WriteLine("Fixed Deposit Account");
    }
}

class Program{
    static void Main(){
        SavingsAccount s = new SavingsAccount(101, 5000, 4.5);
        CheckingAccount c = new CheckingAccount(102, 8000, 2000);
        FixedDepositAccount f = new FixedDepositAccount(103, 20000, 5);

        s.DisplayAccountType();
        c.DisplayAccountType();
        f.DisplayAccountType();
    }
}
