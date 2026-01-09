using System;

class CircularTour
{
    static void Main()
    {
        int[] petrol = { 6, 3, 7 };
        int[] distance = { 4, 6, 3 };

        int startPump = FindStartingPump(petrol, distance);

        if (startPump == -1)
            Console.WriteLine("No possible circular tour");
        else
            Console.WriteLine("Start from petrol pump index: " + startPump);
    }

    static int FindStartingPump(int[] petrol, int[] distance)
    {
        int currentFuel = 0;
        int fuelDeficit = 0;
        int startIndex = 0;

        for (int i = 0; i < petrol.Length; i++)
        {
            currentFuel += petrol[i] - distance[i];

            if (currentFuel < 0)
            {
                fuelDeficit += currentFuel;
                startIndex = i + 1;
                currentFuel = 0;
            }
        }

        if (currentFuel + fuelDeficit >= 0)
            return startIndex;
        else
            return -1;
    }
}
