class UserAccount
{
    private string name;
    private string emailId;
    private long phoneNumber;
    private string accountType;
    private string accountNumber;

    public long Balance { get; private set; }

    public UserAccount(string name, string emailId, long phoneNumber,
                       string accountType, string accountNumber, long balance)
    {
        this.name = name;
        this.emailId = emailId;
        this.phoneNumber = phoneNumber;
        this.accountType = accountType;
        this.accountNumber = accountNumber;
        Balance = balance;
    }

    public void Deposit(long amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Invalid deposit amount.");
            return;
        }

        Balance += amount;
        Console.WriteLine("Deposited: " + amount);
    }

    public void Withdraw(long amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Invalid withdrawal amount.");
        }
        else if (amount > Balance)
        {
            Console.WriteLine("Withdrawal failed: Insufficient balance.");
        }
        else
        {
            Balance -= amount;
            Console.WriteLine("Withdrawn: " + amount);
        }
    }

    public void CheckBalance()
    {
        Console.WriteLine("Current Balance: " + Balance);
    }

    public void DisplayUserDetails()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Email ID: " + emailId);
        Console.WriteLine("Phone Number: " + phoneNumber);
        Console.WriteLine("Account Type: " + accountType);
        Console.WriteLine("Account Number: " + accountNumber);
        Console.WriteLine("Balance: " + Balance);
    }
}


