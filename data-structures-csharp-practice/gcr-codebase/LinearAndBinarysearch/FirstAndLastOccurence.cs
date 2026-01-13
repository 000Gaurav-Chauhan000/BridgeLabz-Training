using System;

class FirstLastOccurrence
{
    static void Main()
    {
        int[] arr = { 2, 4, 4, 4, 6, 8, 8 };

        int target = 4;

        int first = FindFirstOccurrenceAlgo(arr, target);
        int last = FindLastOccurrenceAlgo(arr, target);

        Console.WriteLine($"First Occurrence: {first}");
        Console.WriteLine($"Last Occurrence: {last}");
    }

    static int FindFirstOccurrenceAlgo(int[] arr, int target)
    {
        int left = 0, right = arr.Length - 1;
        int result = -1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
            {
                result = mid;
                right = mid - 1; // move left
            }
            else if (arr[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return result;
    }

    static int FindLastOccurrenceAlgo(int[] arr, int target)
    {
        int left = 0, right = arr.Length - 1;
        int result = -1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
            {
                result = mid;
                left = mid + 1; // move right
            }
            else if (arr[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return result;
    }
}
