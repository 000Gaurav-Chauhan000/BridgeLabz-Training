using System;
class PowerOfANumber
{
    static void Main()
    {
        Console.WriteLine("Enter a number : ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the power of the number:  ");
        int power = Convert.ToInt32(Console.ReadLine());

        int result = number;

        for (int i = 1; i < power; i++){
            result *= number;
        }
        Console.WriteLine(result);
    }
}
