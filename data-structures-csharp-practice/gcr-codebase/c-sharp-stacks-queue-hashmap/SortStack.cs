using System;
using System.Collections;

class SortStack
{
    static void Main()
    {
        Stack stack = new Stack();

        stack.Push(30);
        stack.Push(10);
        stack.Push(50);
        stack.Push(20);

        Console.WriteLine("Original Stack:");
        Display(stack);

        Sort(stack);

        Console.WriteLine("\nSorted Stack (Ascending):");
        Display(stack);
    }

    static void Sort(Stack stack)
    {
        if (stack.Count == 0)
            return;

        int top = (int)stack.Pop();

        Sort(stack);

        InsertInSortedOrder(stack, top);
    }

    static void InsertInSortedOrder(Stack stack, int value)
    {
        if (stack.Count == 0 || (int)stack.Peek() <= value)
        {
            stack.Push(value);
            return;
        }

        int temp = (int)stack.Pop();

        InsertInSortedOrder(stack, value);

        stack.Push(temp);
    }

    static void Display(Stack stack)
    {
        foreach (int item in stack)
            Console.Write(item + " ");
        Console.WriteLine();
    }
}
