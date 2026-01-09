using System;
using System.Collections.Generic;

class PairWithGivenSum
{
    static void Main()
    {
        int[] numbers = { 8, 7, 2, 5, 3, 1 };
        int targetSum = 10;

        CheckPair(numbers, targetSum);
    }

    static void CheckPair(int[] arr, int target)
    {
        Dictionary<int, bool> visitedNumbers = new Dictionary<int, bool>();

        foreach (int currentNumber in arr)
        {
            int requiredNumber = target - currentNumber;

            if (visitedNumbers.ContainsKey(requiredNumber))
            {
                Console.WriteLine(
                    $"Pair found: {currentNumber} + {requiredNumber} = {target}"
                );
                return;
            }

            if (!visitedNumbers.ContainsKey(currentNumber))
                visitedNumbers[currentNumber] = true;
        }

        Console.WriteLine("No pair found with the given sum");
    }
}