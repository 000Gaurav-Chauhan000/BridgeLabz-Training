using System;

class HarshadNumber
{
    static void Main()
    {
        Console.WriteLine("Enter a number : ");
        int number = Convert.ToInt16(Console.ReadLine());
        int temp = number;
        int sum = 0;

        while (temp !=0)
        {
            int digits = temp % 10;
            sum += digits;
           temp/= 10;
        }
        if (number %  sum == 0)
        {
             Console.WriteLine("It's a Harshad Number");
        }
        else
        {
            Console.WriteLine("It's not a Harshad Number");
        }
       
    }
}