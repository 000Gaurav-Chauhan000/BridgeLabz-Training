using System;

class BMI
{
    static void Main()
    {
        Console.Write("Enter weight in kg: ");
        double weight = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter height in cm: ");
        double heightCm = Convert.ToDouble(Console.ReadLine());

        double heightMeter = heightCm / 100;
        double bmi = weight / (heightMeter * heightMeter);

        Console.WriteLine("BMI = " + bmi);

        if (bmi <= 18.4)
        {
            Console.WriteLine("Underweight");
        }
        else if (bmi >= 18.5 && bmi <= 24.9)
        {
            Console.WriteLine("Normal");
        }
        else if (bmi >= 25 && bmi <= 39.9)
        {
            Console.WriteLine("Overweight");
        }
        else
        {
            Console.WriteLine("Obese");
        }
    }
}
