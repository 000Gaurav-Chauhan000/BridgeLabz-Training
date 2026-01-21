using System;
using System.Collections.Generic;

class QueueReversal
{
    public static void ReverseQueueAlgo<T>(Queue<T> queue)
    {
        if (queue.Count == 0)
            return;

        T front = queue.Dequeue();
        ReverseQueueAlgo(queue);
        queue.Enqueue(front);
    }

    static void Main()
    {
        Queue<int> q = new Queue<int>();
        q.Enqueue(10);
        q.Enqueue(20);
        q.Enqueue(30);

        ReverseQueueAlgo(q);

        Console.WriteLine(string.Join(", ", q)); 
    }
}
