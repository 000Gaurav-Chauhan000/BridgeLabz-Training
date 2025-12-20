using System;

class SideOfSquare
{
    static void Main()
    {

    Console.WriteLine("Enter the perimeter of the square : ");
    double perimeter = Convert.ToDouble(Console.ReadLine());
    double side = perimeter/4;

    Console.WriteLine("The side of square with perimeter "+ perimeter+ " is : "+ side);
    }
}