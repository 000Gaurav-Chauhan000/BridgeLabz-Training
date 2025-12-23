using System;
class SmallerNumber
{
    static void Main()
    {
        Console.WriteLine("Enter 1st number");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter 2nd number");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter 3rd number");
        int num3 = Convert.ToInt32(Console.ReadLine());

       
            Console.WriteLine("Is the first number smallest of the three ? : " + ((num1 < num2) && (num1 < num3 )));
    }
}