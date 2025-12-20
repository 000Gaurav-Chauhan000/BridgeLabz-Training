using System;

class TemperatureConversion
{
    static void Main()
    {
        Console.Write("Enter temperature in Fahrenheit: ");
        double fahrenheit =Convert.ToDouble(Console.ReadLine());

        double result = (fahrenheit-32)*5/9;

        Console.WriteLine("The "+fahrenheit+" Fahrenheit is "+result+" Celsius");
    }
}
