using System;

class EarthVolume
{
    static void Main()
    {
        double radiusKm = 6378;
        double volumeKm3 = (4.0 / 3) * Math.PI *Math.Pow(radiusKm, 3);

        double kmToMiles = 0.621371;
        double radiusMiles = radiusKm * kmToMiles;
        double volumeMiles3 = (4.0 / 3) * Math.PI* Math.Pow(radiusMiles, 3);

       Console.WriteLine("The volume of Earth is approximately " + volumeKm3 + " cubic kilometers and " + volumeMiles3 + " cubic miles");

    }
}
