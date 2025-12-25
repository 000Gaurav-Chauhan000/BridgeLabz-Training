using System;

class WindTemperature
{
    static double calculateWindChill(double temperature, double windSpeed)
    {
        double windChill =
            35.74 + 0.6215 * temperature + (0.4275*temperature - 35.75) * Math.Pow(windSpeed, 0.16);

        return windChill;
    }

    static void Main()
    {
        Console.WriteLine("enter temperature : ");
        double temperature = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("enter wind speed : ");
        double windSpeed = Convert.ToDouble(Console.ReadLine());

        double result = calculateWindChill(temperature, windSpeed);

        Console.WriteLine("Wind Chill Temperature: " + Math.Round(result, 2));
    }
}
