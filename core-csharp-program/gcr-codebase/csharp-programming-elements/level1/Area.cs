using System;

class Area
{
    static void Main()
    {
        Console.Write("Enter the base of the triangle in inches: ");
        double baseInches = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the height of the triangle in inches: ");
        double heightInches = Convert.ToDouble(Console.ReadLine());

        double areaInSqInches = 0.5*baseInches*heightInches;
        double areaInSqCm = areaInSqInches*2.54*2.54;

        double heightCm = heightInches*2.54;
        int heightFeet = (int)(heightInches /12);
        double remainingInches = heightInches%12;

        Console.WriteLine("\nArea of the triangle:");

        Console.WriteLine("In square inches: "+areaInSqInches.ToString("F2") +" square inches");

        Console.WriteLine("In square centimeters: "+areaInSqCm.ToString("F2")+" square cm");

        Console.WriteLine("\nHeight of the triangle:");

        Console.WriteLine("In cm: " + heightCm.ToString("F2")+" cm");

        Console.WriteLine("In feet and inches: " + heightFeet + " ft " + remainingInches.ToString("F2") + " in");

    }
}
