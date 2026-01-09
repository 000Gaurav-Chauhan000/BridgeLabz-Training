using System;
using System.Collections.Generic;

class SlidingWindowMaximum
{
    static void Main()
    {
        int[] numbers = { 1, 3, -1, -3, 5, 3, 6, 7 };
        int windowSize = 3;

        FindMaximum(numbers, windowSize);
    }

    static void FindMaximum(int[] arr, int k)
    {
        LinkedList<int> deque = new LinkedList<int>();

        for (int i = 0; i < arr.Length; i++)
        {
            if (deque.Count > 0 && deque.First.Value <= i - k)
            {
                deque.RemoveFirst();
            }

            while (deque.Count > 0 && arr[deque.Last.Value] < arr[i])
            {
                deque.RemoveLast();
            }

            deque.AddLast(i);

            if (i >= k - 1)
            {
                Console.Write(arr[deque.First.Value] + " ");
            }
        }
    }
}
