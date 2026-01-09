using System;
using System.Collections.Generic;

class ZeroSumSubarrays
{
    static void Main()
    {
        int[] numbers = { 6, 3, -1, -3, 4, -2, 2, 4, 6, -12, -7 };

        FindZeroSumSubarrays(numbers);
    }

    static void FindZeroSumSubarrays(int[] arr)
    {
        Dictionary<int, List<int>> sumMap = new Dictionary<int, List<int>>();

        int currentSum = 0;

        if (!sumMap.ContainsKey(0))
            sumMap[0] = new List<int>();

        sumMap[0].Add(-1);

        for (int i = 0; i < arr.Length; i++)
        {
            currentSum += arr[i];

            if (sumMap.ContainsKey(currentSum))
            {
                foreach (int startIndex in sumMap[currentSum])
                {
                    Console.WriteLine(
                        $"Zero-sum subarray found from index {startIndex + 1} to {i}"
                    );
                }
            }

            if (!sumMap.ContainsKey(currentSum))
                sumMap[currentSum] = new List<int>();

            sumMap[currentSum].Add(i);
        }
    }
}
