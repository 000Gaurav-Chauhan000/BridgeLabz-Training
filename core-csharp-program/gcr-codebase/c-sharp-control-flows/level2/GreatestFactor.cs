using System;
class GreatestFactor
{
    static void Main() {
        Console.Write("Enter a number : ");
        int num = Convert.ToInt16(Console.ReadLine());

        int greatestFactor = 1;

        for (int i = num/2; i >= 1; i--)
        {
            if (num % i == 0)
            {
                greatestFactor = i;
                break;
            }
        }

        Console.WriteLine("Greatest factor is: " + greatestFactor);
    }
}
