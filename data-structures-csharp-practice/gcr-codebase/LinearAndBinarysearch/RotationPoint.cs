using System;

class RotationPoint
{
    static void Main()
    {
        int[] arr = { 4, 5, 6, 7, 1, 2, 3 };

        int index = FindRotationPointAlgo(arr);

        Console.WriteLine("Rotation point index: " + index);
        Console.WriteLine("Smallest element: " + arr[index]);
    }

    static int FindRotationPointAlgo(int[] arr)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left < right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] > arr[right])
                left = mid + 1;
            else
                right = mid;
        }

        return left;
    }
}
