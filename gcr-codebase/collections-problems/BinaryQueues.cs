using System;
using System.Collections.Generic;

class BinaryQueues
{
    public static List<string> GenerateBinaryNumbersAlgo(int n)
    {
        List<string> result = new List<string>();
        if (n <= 0) return result;

        Queue<string> q = new Queue<string>();
        q.Enqueue("1");

        for (int i = 0; i < n; i++)
        {
            string current = q.Dequeue();
            result.Add(current);

            q.Enqueue(current + "0");
            q.Enqueue(current + "1");
        }

        return result;
    }

    static void Main()
    {
        int N = 5;
        List<string> binaries = GenerateBinaryNumbersAlgo(N);

        Console.WriteLine(string.Join(", ", binaries)); // 1, 10, 11, 100, 101
    }
}
