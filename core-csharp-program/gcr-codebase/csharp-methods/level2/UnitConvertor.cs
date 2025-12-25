using System;

class UnitConvertor{
    public static double FahrenheitToCelsius(double fahrenheit){
        return (fahrenheit - 32) * 5 / 9;
    }

    public static double CelsiusToFahrenheit(double celsius){
        return (celsius * 9 / 5) + 32;
    }

    public static double PoundsToKilograms(double pounds){
        return pounds * 0.453592;
    }

    public static double KilogramsToPounds(double kilograms){
        return kilograms * 2.20462;
    }

    public static double GallonsToLiters(double gallons){
        return gallons * 3.78541;
    }

    public static double LitersToGallons(double liters){
        return liters * 0.264172;
    }
}
class ConversionTest{
    static void Main(){
        Console.WriteLine(UnitConvertor.FahrenheitToCelsius(98.6));
        Console.WriteLine(UnitConvertor.CelsiusToFahrenheit(37));
        Console.WriteLine(UnitConvertor.PoundsToKilograms(150));
        Console.WriteLine(UnitConvertor.KilogramsToPounds(70));
        Console.WriteLine(UnitConvertor.GallonsToLiters(2));
        Console.WriteLine(UnitConvertor.LitersToGallons(5));
    }
}
