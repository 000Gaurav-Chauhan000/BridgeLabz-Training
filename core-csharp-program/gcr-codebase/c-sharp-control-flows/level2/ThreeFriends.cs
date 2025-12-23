using System;

class ThreeFriends
{
    static void Main()
    {
        Console.Write("Enter Amar's age: ");
        int amarAge = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Amar's height: ");
        double amarHeight = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Akbar's age: ");
        int akbarAge = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Akbar's height: ");
        double akbarHeight = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Anthony's age: ");
        int anthonyAge = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Anthony's height: ");
        double anthonyHeight = Convert.ToDouble(Console.ReadLine());

        if (amarAge <= akbarAge && amarAge <= anthonyAge)
        {
            Console.WriteLine("Amar is the youngest friend");
        }
        else if (akbarAge <= amarAge && akbarAge <= anthonyAge)
        {
            Console.WriteLine("Akbar is the youngest friend");
        }
        else
        {
            Console.WriteLine("Anthony is the youngest friend");
        }
        if (amarHeight >= akbarHeight && amarHeight >= anthonyHeight)
        {
            Console.WriteLine("Amar is the tallest friend");
        }
        else if (akbarHeight >= amarHeight && akbarHeight >= anthonyHeight)
        {
            Console.WriteLine("Akbar is the tallest friend");
        }
        else
        {
            Console.WriteLine("Anthony is the tallest friend");
        }
    }
}
