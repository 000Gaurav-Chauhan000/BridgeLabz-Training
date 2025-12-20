using System;

class PenDistribution
{
    static void Main()
    {
        int pens = 14;
        int students = 3;

        int remaining = pens % students;

        int distributed = (pens-remaining)/students;
        Console.WriteLine("The number of pens per student is" + distributed+ ", and the remaining andd not distributed are "+ remaining);

    }
}