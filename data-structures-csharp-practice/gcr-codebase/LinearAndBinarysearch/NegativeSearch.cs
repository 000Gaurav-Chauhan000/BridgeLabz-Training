using System;

class NegativerSearch
{
    static void Main()
    {
        int[] numbers = { 5, 3, 0, 7, -2, 4, -6 };

        int result = FindFirstNegativeAlgo(numbers);

        if (result != int.MinValue)
            Console.WriteLine("First negative number: " + result);
        else
            Console.WriteLine("No negative number found.");
    }

    static int FindFirstNegativeAlgo(int[] arr)
    {
        foreach (int num in arr)
        {
            if (num < 0)
                return num; 
        }

        return -1;
    }
}
