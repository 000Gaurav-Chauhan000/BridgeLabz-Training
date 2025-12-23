using System;
using System.Diagnostics;
class Divisibility
{
    static void Main()
    {
        Console.WriteLine("Enter a number");

        int number = int.Parse(Console.ReadLine());
        if(number % 5 == 0)
        {
            Console.WriteLine("The number is divisible by 5");
        }
        else
        {
           Console.WriteLine("The number is not divisible by 5");
        }
    }
}
