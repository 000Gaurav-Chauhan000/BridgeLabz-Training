using System;

class MergeSort
{
    static void Main()
    {
        int[] bookPrices = { 499, 299, 799, 199, 599, 399 };

        MergeSortAlgo(bookPrices, 0, bookPrices.Length - 1);

        foreach (int price in bookPrices)
        {
            Console.Write(price + " ");
        }
    }

    static void MergeSortAlgo(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int mid = left + (right - left) / 2;

            MergeSortAlgo(arr, left, mid);
            MergeSortAlgo(arr, mid + 1, right);

            MergeAlgo(arr, left, mid, right);
        }
    }

    static void MergeAlgo(int[] arr, int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;

        int[] L = new int[n1];
        int[] R = new int[n2];

        for (int i = 0; i < n1; i++)
            L[i] = arr[left + i];

        for (int j = 0; j < n2; j++)
            R[j] = arr[mid + 1 + j];

        int iIndex = 0, jIndex = 0, k = left;

        while (iIndex < n1 && jIndex < n2)
        {
            if (L[iIndex] <= R[jIndex])
            {
                arr[k] = L[iIndex];
                iIndex++;
            }
            else
            {
                arr[k] = R[jIndex];
                jIndex++;
            }
            k++;
        }

        while (iIndex < n1)
        {
            arr[k] = L[iIndex];
            iIndex++;
            k++;
        }

        while (jIndex < n2)
        {
            arr[k] = R[jIndex];
            jIndex++;
            k++;
        }
    }
}
