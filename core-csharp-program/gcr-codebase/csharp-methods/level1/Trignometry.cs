using System;

class Trigonometry{
    static double[] calculateTrigonometricFunctions(double angle)
    {
        double radians = angle * Math.PI / 180;

        double[] result = new double[3];
        result[0] = Math.Sin(radians);
        result[1] = Math.Cos(radians);
        result[2] = Math.Tan(radians);

        return result;
    }

    static void Main()
    {
        Console.WriteLine("Enter angle in degrees : ");
        double angle = Convert.ToDouble(Console.ReadLine());

        double[] values = calculateTrigonometricFunctions(angle);

        Console.WriteLine("Sine : " + values[0]);
        Console.WriteLine("Cosine : " + values[1]);
        Console.WriteLine("Tangent : " + values[2]);
    }
}
