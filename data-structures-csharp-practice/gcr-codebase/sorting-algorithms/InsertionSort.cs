using System;

class InsertionSort
{
    static void Main()
    {
        int[] employeeIds = { 105, 102, 110, 101, 108 };

        InsertionSortAlgo(employeeIds);

        foreach (int id in employeeIds)
        {
            Console.Write(id + " ");
        }
    }

    static void InsertionSortAlgo(int[] arr)
    {
        int n = arr.Length;

        for (int i = 1; i < n; i++)
        {
            int key = arr[i];
            int j = i - 1;

            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j--;
            }

            arr[j + 1] = key;
        }
    }
}
