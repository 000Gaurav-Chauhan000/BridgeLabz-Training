using System;
using System.Collections.Generic;

class LasttNthElement
{
    public static T FindNthFromEndAlgo<T>(LinkedList<T> list, int n)
    {
        if (n <= 0) throw new ArgumentException("N must be positive");

        var fast = list.First;
        var slow = list.First;

        for (int i = 0; i < n; i++)
        {
            if (fast == null)
                throw new ArgumentException("N is greater than list length");
            fast = fast.Next;
        }

        while (fast != null)
        {
            fast = fast.Next;
            slow = slow.Next;
        }

        return slow.Value;
    }

    static void Main()
    {
        LinkedList<string> list = new LinkedList<string>(
            ["A", "B", "C", "D", "E"]);

        Console.WriteLine(FindNthFromEndAlgo(list, 2)); // D
    }
}
