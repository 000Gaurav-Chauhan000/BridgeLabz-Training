using System;

class ArmStrongNumber
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int sum = 0;
        int originalNumber = number;

        while (originalNumber != 0)
        {
            int digit = originalNumber % 10;
            sum += digit * digit * digit;
            originalNumber /= 10;
        }

        if (sum == number)
            Console.WriteLine(number + " is an Armstrong Number");
        else
            Console.WriteLine(number + " not an Armstrong Number");
    }
}
