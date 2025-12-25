using System;

class DistanceConvertorV2{
    public static double YardsToFeet(double yards){
        return yards * 3;
    }

    public static double FeetToYards(double feet){
        return feet * 0.333333;
    }

    public static double MetersToInches(double meters){
        return meters * 39.3701;
    }

    public static double InchesToMeters(double inches){
        return inches * 0.0254;
    }

    public static double InchesToCentimeters(double inches){
        return inches * 2.54;
    }
}

class LengthConvertorTest{
    static void Main()
    {
          Console.WriteLine(DistanceConvertorV2.YardsToFeet(10));
        Console.WriteLine(DistanceConvertorV2.FeetToYards(10));
        Console.WriteLine(DistanceConvertorV2.MetersToInches(10));
        Console.WriteLine(DistanceConvertorV2.InchesToMeters(20));
        Console.WriteLine(DistanceConvertorV2.InchesToCentimeters(15));
    }
}
