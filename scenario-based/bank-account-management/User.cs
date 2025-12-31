class User
{
    private int userId;
    private string name;
    private string email;
    private long phoneNumber;
    private string address;
    private long accountNumber;
    private int pin;

    public User(int userId, string name, string email, long phoneNumber,
                 string address, long accountNumber, int pin){
        this.userId = userId;
        this.name = name;
        this.email = email;
        this.phoneNumber = phoneNumber;
        this.address = address;
        this.accountNumber = accountNumber;
        this.pin = pin;
    }

    public void ShowDetails()
    {
        Console.WriteLine("User ID: " + userId);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Email: " + email);
        Console.WriteLine("Phone Number: " + phoneNumber);
        Console.WriteLine("Address: " + address);
        Console.WriteLine("Account Number: " + accountNumber);
    }

    public string GetName()
    {
        return name;
    }

    public long GetAccountNumber()
    {
        return accountNumber;
    }
}
