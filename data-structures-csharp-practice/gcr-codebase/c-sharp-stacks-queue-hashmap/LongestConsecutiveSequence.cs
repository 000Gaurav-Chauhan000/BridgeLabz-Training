using System;
using System.Collections.Generic;

class LongestConsecutiveSequence
{
    static void Main()
    {
        int[] numbers = { 100, 4, 200, 1, 3, 2 };

        int longest = FindLongestSequence(numbers);

        Console.WriteLine("Longest Consecutive Sequence Length: " + longest);
    }

    static int FindLongestSequence(int[] arr)
    {
        HashSet<int> numberSet = new HashSet<int>();

        foreach (int num in arr)
            numberSet.Add(num);

        int longestLength = 0;

        foreach (int num in arr)
        {
            if (!numberSet.Contains(num - 1))
            {
                int currentNumber = num;
                int currentLength = 1;

                while (numberSet.Contains(currentNumber + 1))
                {
                    currentNumber++;
                    currentLength++;
                }

                if (currentLength > longestLength)
                    longestLength = currentLength;
            }
        }

        return longestLength;
    }
}
