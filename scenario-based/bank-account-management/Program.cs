using System;

class Program
{
    static void Main(string[] args)
    {
        Bank bank = new Bank("NCFC", 99555972, "Beijing", 20000, "Shen Shuan");

        User user1 = new User(
            99420,
            "Sun Mayoxi",
            "SunMayoxi@BitoriSocialCredit.com",
            5557742030L,
            "Nian-Jiang, ki-Xi sui Villa Hno. 420",
            47254100300L,
            997845
        );

        bank.OpenAccount(user1);

        bank.Deposit(3000);
        bank.Withdraw(1500);
        bank.Withdraw(10000); // overdraft attempt
        bank.CheckBalance();

        bank.ShowDetails();
    }
}

