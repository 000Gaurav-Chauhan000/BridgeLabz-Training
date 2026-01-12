using System;
using System.Collections.Generic;
using System.Text;

namespace Furniture_MAnufacturing
{

    class FurnitureRodCutting
    {
        public static int MaxRevenueAlgo(int[] price, int totalLength)
        {
            int[] dp = new int[totalLength + 1];
            dp[0] = 0;

            for (int j = 1; j <= totalLength; j++)
            {
                int maxRevenue = int.MinValue;

                for (int i = 1; i <= j; i++)
                {
                    maxRevenue = Math.Max(maxRevenue, price[i] + dp[j - i]);
                }

                dp[j] = maxRevenue;
            }
                return dp[totalLength];
        }
    }

}
