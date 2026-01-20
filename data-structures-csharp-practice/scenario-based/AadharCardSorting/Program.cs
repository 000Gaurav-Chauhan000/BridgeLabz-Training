using System;
namespace AadharCardSorting
{
    class Program
    {
        static void Main()
        {
            long[] arr = {
            9876543210L, 1234567890L, 8765432109L, 2345678901L,
            1098758432L, 9012345678L, 9988776655L, 8877665544L
        };
            SortClass sort = new SortClass();

            sort.RadixSortAlgo(arr);

            foreach (long i in arr)
            Console.WriteLine(i);

            long key = 2345678901L;
            int index = sort.BinarySearch(arr, key);
        }
    }
}