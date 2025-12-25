using System;

class AtheleteRun
{   
    static void triangleRun(double perimeter){
        Console.WriteLine("The athelete will make "+5000/perimeter+ " rounds to run 5Kms");
    }
    static void Main()
    {
        Console.WriteLine("Enter side1 : ");
        double side1 = double.Parse(Console.ReadLine());

         Console.WriteLine("Enter side2 : ");
        double side2 = double.Parse(Console.ReadLine());

         Console.WriteLine("Enter side3 : ");
        double side3 = double.Parse(Console.ReadLine());

        double perimeter = side1 + side2 + side3;
        triangleRun(perimeter);
    }
}