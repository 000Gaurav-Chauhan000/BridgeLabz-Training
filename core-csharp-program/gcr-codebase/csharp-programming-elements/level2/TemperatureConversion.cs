using System;

class TemperatureConversion
{
    static void Main()
    {
        Console.Write("Enter temperature in Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        double result = (celsius*9/5)+ 32;

        Console.WriteLine("The " + celsius + " Celsius is "+result+" Fahrenheit");
    }
}
