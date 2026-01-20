using System.Numerics;
namespace AadharCardSorting
{
    internal class SortClass
    {
        public void RadixSortAlgo(long[] arr)
        {
            long max = GetMax(arr);

            for (long exp = 1; (max / exp) > 0; exp *= 10)
            {
                CountSort(arr, exp);
            }
        }

        public long GetMax(long[] arr)
        {
            long max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }
        public void CountSort(long[] arr, long exp)
        {
            int n = arr.Length;
            long[] output = new long[n];
            int[] count = new int[10];

            for (int i = 0; i < n; i++)
            {
                int digit = (int)(arr[i] / exp % 10);
                count[digit]++;
            }
            for (int i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
            }
            for (int i = n - 1; i >= 0; i--)
            {
                int digit = (int)(arr[i] / exp % 10);
                output[count[digit] - 1] = arr[i];
                count[digit]--;
            }
            for (int i = 0; i < n; i++)
            {
                arr[i] = output[i];
            }
        }
        public int BinarySearch(long[] arr, long key)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == key)
                    return mid;

                if (arr[mid] < key)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return -1;
        }

    }
}