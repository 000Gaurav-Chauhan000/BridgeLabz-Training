using System;

class BankAccount
{
    public static string bankName = "National Bank";
    private static int totalAccounts = 0;

    public readonly int AccountNumber;
    public string AccountName;

    public BankAccount(int AccountNumber, string AccountName)
    {
        this.AccountNumber = AccountNumber;
        this.AccountName = AccountName;
        totalAccounts++;
    }

    public static void GetTotalAccounts()
    {
        Console.WriteLine(totalAccounts);
    }

    public void Display(object o)
    {
        if (o is BankAccount)
        {
            Console.WriteLine(bankName);
            Console.WriteLine(AccountNumber);
            Console.WriteLine(AccountName);
        }
    }

    static void Main()
    {
        BankAccount acc1 = new BankAccount(101, "Elain");
        BankAccount acc2 = new BankAccount(102, "Wu - Ku");

        acc1.Display(acc1);
        acc2.Display(acc2);

        BankAccount.GetTotalAccounts();
    }
}
