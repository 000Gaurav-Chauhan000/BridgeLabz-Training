
using System;
namespace Metal_Cutting { 
    class Program
    {
        static void Main()
        {
            int[] price = { 0, 2, 6, 7, 10, 13 };
            int rodLength = 5;

            int result = RodCutting.RodCuttingAlgo(price, rodLength);

            Console.WriteLine("Maximum profit: " + result);
        }
    }
}