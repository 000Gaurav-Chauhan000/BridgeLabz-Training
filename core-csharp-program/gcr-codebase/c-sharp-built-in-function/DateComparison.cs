using System;

class DateComparison{
    static void Main(){
        Console.WriteLine("Enter first date (yyyy-MM-dd):");
        DateTime d1 = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("Enter second date (yyyy-MM-dd):");
        DateTime d2 = DateTime.Parse(Console.ReadLine());

        if (d1 < d2)    Console.WriteLine("First date is before second date");
        else if (d1 > d2)    Console.WriteLine("First date is after second date");
        else    Console.WriteLine("Both dates are the same");
    }
}