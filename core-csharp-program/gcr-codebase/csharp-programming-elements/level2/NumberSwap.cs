using System;

class NumberSwap
{
    static void Main()
    {
        Console.Write("Enter number1: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number2: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int temp = num1;
        num1 = num2;
        num2 = temp;

        Console.WriteLine("The swapped numbers are "+num1 + " and "+ num2);
    }
}
