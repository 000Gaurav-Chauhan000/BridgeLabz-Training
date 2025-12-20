using System;

class YardsAndMiles
{
    static void Main()
    {
        Console.Write("Enter distance in feet: ");
        double feet = Convert.ToDouble(Console.ReadLine());

        double yards = feet / 3;
        double miles = yards / 1760;

        Console.WriteLine("Distance in yards: " + yards +" and the distance in miles: " + miles);
       
    }
}