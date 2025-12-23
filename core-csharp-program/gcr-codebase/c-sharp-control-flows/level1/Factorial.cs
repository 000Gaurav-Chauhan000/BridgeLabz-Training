using System;

class Factorial
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num < 0)
        {
            Console.WriteLine("No factorial for negative numbers");
            return;
        }

        int factorial = 1;

        while (num > 1)
        {
            factorial *= num;
            num--;
        }

        Console.WriteLine(factorial);
    }
}
