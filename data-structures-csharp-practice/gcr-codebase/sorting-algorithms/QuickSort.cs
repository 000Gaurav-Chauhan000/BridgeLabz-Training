using System;

class QuickSort
{
    static void Main()
    {
        int[] productPrices = { 1499, 799, 2999, 499, 1999, 999 };

        QuickSortAlgo(productPrices, 0, productPrices.Length - 1);

        foreach (int price in productPrices)
        {
            Console.Write(price + " ");
        }
    }

    static void QuickSortAlgo(int[] prices, int startIndex, int endIndex)
    {
        if (startIndex < endIndex)
        {
            int pivotPosition = PartitionAlgo(prices, startIndex, endIndex);

            QuickSortAlgo(prices, startIndex, pivotPosition - 1);
            QuickSortAlgo(prices, pivotPosition + 1, endIndex);
        }
    }

    static int PartitionAlgo(int[] prices, int startIndex, int endIndex)
    {
        int pivotValue = prices[endIndex];
        int smallerElementIndex = startIndex - 1;

        for (int currentIndex = startIndex; currentIndex < endIndex; currentIndex++)
        {
            if (prices[currentIndex] < pivotValue)
            {
                smallerElementIndex++;
                Swap(prices, smallerElementIndex, currentIndex);
            }
        }

        Swap(prices, smallerElementIndex + 1, endIndex);
        return smallerElementIndex + 1;
    }

    static void Swap(int[] prices, int firstIndex, int secondIndex)
    {
        int tempValue = prices[firstIndex];
        prices[firstIndex] = prices[secondIndex];
        prices[secondIndex] = tempValue;
    }
}
