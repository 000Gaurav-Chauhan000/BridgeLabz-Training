using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Enter first number : ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter second number : ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter any of these operators (+, -, *, /):");
        string operation = Console.ReadLine();

        switch (operation)
        {
            case "+":
                Console.WriteLine("Result = " + (num1 + num2));
                break;

            case "-":
                Console.WriteLine("Result = " + (num1 - num2));
                break;

            case "*":
                Console.WriteLine("Result = " + (num1 * num2));
                break;

            case "/":
                if (num2 != 0)
                    Console.WriteLine("Result = " + (num1 / num2));
                else
                    Console.WriteLine("Cannot divide by zero");
                break;

            default:
                Console.WriteLine("Invalid Operator");
                break;
        }
    }
}
