using System;

class Travelling
{
    static void Main()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter starting city (fromCity): ");
        string fromCity = Console.ReadLine();

        Console.Write("Enter via city (viaCity): ");
        string viaCity = Console.ReadLine();

        Console.Write("Enter destination city (toCity): ");
        string toCity = Console.ReadLine();

        Console.Write("Enter distance from " + fromCity + " to " + viaCity + " in miles: ");
        double fromToVia = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter distance from " + viaCity + " to " + toCity + " in miles: ");
        double viaToFinalCity = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter total time taken for the journey in hours: ");
        double timeTaken = Convert.ToDouble(Console.ReadLine());

        double totalDistance = fromToVia + viaToFinalCity;
        double averageSpeed = totalDistance / timeTaken;

        Console.WriteLine("The results of the trip are: " + name + ", total distance " + totalDistance + " miles, and average speed " + averageSpeed + " mph");
    }
}
