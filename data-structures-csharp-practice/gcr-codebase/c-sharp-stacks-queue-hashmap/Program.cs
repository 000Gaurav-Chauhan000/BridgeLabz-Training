using System;
using System.Collections;

class QueueUsingStacks
{
    Stack inStack = new Stack();
    Stack outStack = new Stack();

    public void Enqueue(int value)
    {
        inStack.Push(value);
        Console.WriteLine(value + " enqueued");
    }

    public void Dequeue()
    {
        if (outStack.Count == 0)
        {
            while (inStack.Count > 0)
            {
                outStack.Push(inStack.Pop());
            }
        }

        if (outStack.Count == 0)
        {
            Console.WriteLine("Queue is empty");
            return;
        }

        int removed = (int)outStack.Pop();
        Console.WriteLine(removed + " dequeued");
    }

    public void Display()
    {
        if (inStack.Count == 0 && outStack.Count == 0)
        {
            Console.WriteLine("Queue is empty");
            return;
        }

        Console.Write("Queue elements: ");

        foreach (int item in outStack)
            Console.Write(item + " ");

        object[] temp = inStack.ToArray();
        for (int i = temp.Length - 1; i >= 0; i--)
            Console.Write(temp[i] + " ");

        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        QueueUsingStacks queue = new QueueUsingStacks();

        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(33);

        queue.Display();

        queue.Dequeue();
        queue.Display();

        queue.Enqueue(40);
        queue.Display();

        queue.Dequeue();
        queue.Dequeue();
        queue.Dequeue();
        queue.Dequeue();
    }
}
