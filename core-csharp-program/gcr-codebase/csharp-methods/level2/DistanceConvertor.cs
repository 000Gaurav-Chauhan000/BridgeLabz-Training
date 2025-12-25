using System;

class DistanceConvertor
{
    public static double ConvertKmToMiles(double km){
        return km * 0.621371;
    }
    public static double ConvertMilesToKm(double miles){
        return miles * 1.60934;
    }
    public static double ConvertMetersToFeet(double meters){
        return meters * 3.28084;
    }
    public static double ConvertFeetToMeters(double feet){
        return feet * 0.3048;
    }
}

class UnitConvertorTest{
    static void Main(){
        Console.WriteLine(DistanceConvertor.ConvertKmToMiles(10));
        Console.WriteLine(DistanceConvertor.ConvertMilesToKm(10));
        Console.WriteLine(DistanceConvertor.ConvertMetersToFeet(10));
        Console.WriteLine(DistanceConvertor.ConvertFeetToMeters(12));
    }
}
