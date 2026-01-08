class Bank
{
    private string bankName;
    private int ifscCode;
    private string branchName;
    private int minimumBalance;
    private string manager;

    private UserAccount account;

    public Bank(string bankName, int ifscCode, string branchName,
                int minimumBalance, string manager){
        this.bankName = bankName;
        this.ifscCode = ifscCode;
        this.branchName = branchName;
        this.minimumBalance = minimumBalance;
        this.manager = manager;
    }

    public void OpenAccount(User user)
    {
        account = new UserAccount(
            user.GetName(),
            "Registered Email",
            0,
            "Savings",
            user.GetAccountNumber().ToString(),
            minimumBalance
        );

        Console.WriteLine("\nAccount opened successfully for " + user.GetName());
        user.ShowDetails();
        account.CheckBalance();
    }

    public void Deposit(long amount)
    {
        account.Deposit(amount);
    }

    public void Withdraw(long amount)
    {
        account.Withdraw(amount);
    }

    public void CheckBalance()
    {
        account.CheckBalance();
    }

    public void ShowDetails()
    {
        Console.WriteLine("\n--- Bank Details ---");
        Console.WriteLine("Bank Name : " + bankName);
        Console.WriteLine("IFSC Code : " + ifscCode);
        Console.WriteLine("Branch Name : " + branchName);
        Console.WriteLine("Minimum Balance : " + minimumBalance);
        Console.WriteLine("Bank Manager : " + manager);
    }
}
