using System;

class Chocolates
{
    static void Main()
    {
        Console.WriteLine("Enter the number of chocolates : ");
        int chocolates = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the number of children : ");
        int children = Convert.ToInt32(Console.ReadLine());

        int remaining = chocolates % children;

        int distributed = (chocolates-remaining)/children;
        Console.WriteLine("The number of chocolatess per children is " + distributed+ ", and the remaining are "+ remaining);

    }
}