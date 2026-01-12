using System;

namespace Metal_Cutting
{

    class RodCutting
    {
        public static int RodCuttingAlgo(int[] price, int length)
        {
            if (length == 0)    return 0;

            int maxRevenue = int.MinValue;

            for (int i = 1; i <= length; i++)
            {
                int revenue = price[i] + RodCuttingAlgo(price, length - i);   
                maxRevenue = Math.Max(maxRevenue, revenue);
            }

            return maxRevenue;
        }
    }
}