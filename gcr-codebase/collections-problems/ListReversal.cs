using System;
using System.Collections;
using System.Collections.Generic;

class ListReversal
{
    public static void ReverseArrayListAlgo(ArrayList list)
    {
        int l = 0, r = list.Count - 1;
        while (l < r)
        {
            object temp = list[l];
            list[l] = list[r];
            list[r] = temp;
            l++;
            r--;
        }
    }

    public static void ReverseLinkedListAlgo<T>(LinkedList<T> list)
    {
        var left = list.First;
        var right = list.Last;

        for (int i = 0; i < list.Count / 2; i++)
        {
            T temp = left.Value;
            left.Value = right.Value;
            right.Value = temp;

            left = left.Next;
            right = right.Previous;
        }
    }

    static void PrintArrayList(ArrayList list)
    {
        foreach (var item in list)
            Console.Write(item + " ");
        Console.WriteLine();
    }

    static void Main()
    {
        ArrayList arrayList = new ArrayList { 11, 32, 43, 54, 51 };
        LinkedList<int> linkedList = new LinkedList<int>(new[] { 12, 92, 35, 42, 55 });

        ReverseArrayListAlgo(arrayList);
        ReverseLinkedListAlgo(linkedList);

        Console.WriteLine("\nAfter:");
        PrintArrayList(arrayList);
        Console.WriteLine(string.Join(" ", linkedList));
    }
}
