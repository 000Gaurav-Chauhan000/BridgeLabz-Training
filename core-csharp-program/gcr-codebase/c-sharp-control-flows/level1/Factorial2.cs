using System;

class Factorial2
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int num = Convert.ToInt32(Console.ReadLine());

        int factorial = 1;

        for (int i = num; i > 1; i--)
        {
            factorial *= i;
        }

        Console.WriteLine(factorial);
    }
}
