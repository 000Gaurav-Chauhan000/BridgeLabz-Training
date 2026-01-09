using System;
using System.Collections.Generic;

class TwoSum
{
    static void Main()
    {
        int[] numbers = { 2, 7, 11, 15 };
        int targetSum = 9;

        int[] result = FindTwoSum(numbers, targetSum);

        if (result.Length == 2)
            Console.WriteLine("Indices: " + result[0] + ", " + result[1]);
        else
            Console.WriteLine("No valid pair found");
    }

    static int[] FindTwoSum(int[] arr, int target)
    {
        Dictionary<int, int> numberIndexMap = new Dictionary<int, int>();

        for (int i = 0; i < arr.Length; i++)
        {
            int currentNumber = arr[i];
            int requiredNumber = target - currentNumber;

            if (numberIndexMap.ContainsKey(requiredNumber))
            {
                return new int[] { numberIndexMap[requiredNumber], i };
            }

            if (!numberIndexMap.ContainsKey(currentNumber))
            {
                numberIndexMap[currentNumber] = i;
            }
        }

        return new int[0];
    }
}
