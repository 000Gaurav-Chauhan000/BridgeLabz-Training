using System;

class Temperature{
    static double FahrenheitToCelsius(double f){
        return (f - 32) * 5 / 9;
    }
    static double CelsiusToFahrenheit(double c){
        return (c * 9 / 5) + 32;
    }
    static void Main(){
        Console.WriteLine("1. Fahrenheit to Celsius");
        Console.WriteLine("2. Celsius to Fahrenheit");
        int choice = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter temperature:");
        double temp = Convert.ToDouble(Console.ReadLine());

        if (choice == 1)    Console.WriteLine(FahrenheitToCelsius(temp));
        else    Console.WriteLine(CelsiusToFahrenheit(temp));
    }
}