using System;
namespace Furniture_MAnufacturing
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] prices = new int[] { 1, 3, 5, 8, 12, 17, 17, 20 };

            int rodLength = 12;

            int result = FurnitureRodCutting.MaxRevenueAlgo(prices, rodLength);
            Console.WriteLine("Maximum Revenue: " + result);

        }
    }
}