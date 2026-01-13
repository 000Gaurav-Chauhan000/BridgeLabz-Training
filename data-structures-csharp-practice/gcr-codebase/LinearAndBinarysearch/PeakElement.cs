using System;

class PeakElement
{
    static void Main()
    {
        int[] arr = { 1, 3, 20, 4, 1, 0 };

        int peakIndex = FindPeakElementAlgo(arr);

        Console.WriteLine($"Peak element found at index {peakIndex} with value {arr[peakIndex]}");
    }

    static int FindPeakElementAlgo(int[] arr)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left < right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] < arr[mid + 1])
                left = mid + 1;
            else
                right = mid;
        }

        return left;
    }
}
