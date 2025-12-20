using System;

class BasicCalculator
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        double number1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double number2 = Convert.ToDouble(Console.ReadLine());

        double sum = number1 + number2;
        double difference = number1 - number2;
        double product = number1 * number2;
        double quotient = number1 / number2;

    Console.WriteLine("Addition: " + sum +", Subtraction: "+difference +", Product: "+product+", Division: "+quotient);
    }
}
