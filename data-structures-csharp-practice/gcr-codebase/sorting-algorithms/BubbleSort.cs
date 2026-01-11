using System;

class BubbleSort
{
    static void Main()
    {
        int[] marks = { 78, 45, 89, 62, 91, 54 };

        Console.WriteLine("Student Marks Before Sorting:");
        PrintArray(marks);

        BubbleSortAlgo(marks);

        Console.WriteLine("\nStudent Marks After Sorting :");
        PrintArray(marks);
    }

    static void BubbleSortAlgo(int[] arr)
    {
        int n = arr.Length;
        bool swapped;

        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;

            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;

                    swapped = true;
                }
            }
            if (!swapped)
                break;
        }
    }

    static void PrintArray(int[] arr)
    {
        foreach (int mark in arr)
        {
            Console.Write(mark + " ");
        }
        Console.WriteLine();
    }
}
