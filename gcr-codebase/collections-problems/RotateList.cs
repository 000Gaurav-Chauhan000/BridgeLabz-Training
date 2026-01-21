using System;
using System.Collections.Generic;

class ListRotation
{
    public static void RotateLeftAlgo<T>(List<T> list, int k)
    {
        int n = list.Count;
        if (n == 0) return;

        k = k % n;
        if (k == 0) return;

        ReverseAlgo(list, 0, k - 1);
        ReverseAlgo(list, k, n - 1);
        ReverseAlgo(list, 0, n - 1);
    }

    static void ReverseAlgo<T>(List<T> list, int left, int right)
    {
        while (left < right)
        {
            T temp = list[left];
            list[left] = list[right];
            list[right] = temp;
            left++;
            right--;
        }
    }

    static void Main()
    {
        List<int> data = new List<int> { 10, 20, 30, 40, 50, 60, 70 };
        RotateLeftAlgo(data, 1);
        Console.WriteLine(string.Join(", ", data)); 
    }
}
