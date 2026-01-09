using System;
using System.Collections;

class StockSpan
{
    static void Main()
    {
        int[] prices = { 100, 80, 60, 70, 60, 75, 85 };
        int[] span = CalculateSpan(prices);

        Console.WriteLine("Stock Prices:");
        Display(prices);

        Console.WriteLine("Stock Span:");
        Display(span);
    }

    static int[] CalculateSpan(int[] prices)
    {
        int n = prices.Length;
        int[] span = new int[n];
        Stack indexStack = new Stack();

        indexStack.Push(0);
        span[0] = 1;

        for (int i = 1; i < n; i++)
        {
            while (indexStack.Count > 0 &&
                   prices[(int)indexStack.Peek()] <= prices[i])
            {
                indexStack.Pop();
            }

            if (indexStack.Count == 0)
                span[i] = i + 1;
            else
                span[i] = i - (int)indexStack.Peek();

            indexStack.Push(i);
        }

        return span;
    }

    static void Display(int[] arr)
    {
        foreach (int value in arr)
            Console.Write(value + " ");
        Console.WriteLine();
    }
}
