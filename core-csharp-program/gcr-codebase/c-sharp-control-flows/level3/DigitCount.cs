using System;

class DigitCount
{
    static void Main()
    {
        Console.WriteLine("Enter an integer ");
        int number = Convert.ToInt32(Console.ReadLine());

        int count = 0;
        int digit = number;

        while(digit != 0)
        {
            digit /= 10;
            count++;
        }
        Console.WriteLine(count);
    }
}