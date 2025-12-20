using System;
using System.Data;
class ProfitLossCalculation
{
    static void Main()
    {
        int costPrice = 129;
        int sellingPrice = 191;
        int profit = sellingPrice - costPrice;
        double profitPercentage = profit*100/(costPrice);
        Console.WriteLine("The cost price is INR "+costPrice + " the selling price is " + sellingPrice + ", the profit is "+ profit +", and the profit percentage is "+profitPercentage);


    }
}