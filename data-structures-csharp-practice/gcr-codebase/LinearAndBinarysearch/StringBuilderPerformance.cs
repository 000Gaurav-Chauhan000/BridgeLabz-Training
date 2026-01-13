using System;
using System.Diagnostics;
using System.Text;

class StringBuilderPerformance
{
    static void Main()
    {
        const int iterations = 100_000;

        Stopwatch swString = Stopwatch.StartNew();
        string normalString = "";

        for (int i = 0; i < iterations; i++)
        {
            normalString += "a";
        }

        swString.Stop();
        Console.WriteLine("String (+) time: " + swString.ElapsedMilliseconds + " ms");

        Stopwatch swBuilder = Stopwatch.StartNew();
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < iterations; i++)
        {
            sb.Append("a");
        }

        swBuilder.Stop();
        Console.WriteLine("StringBuilder time: " + swBuilder.ElapsedMilliseconds + " ms");
    }
}
