using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int withdrawAmount = 880;

        Console.WriteLine("Scenario A");
        int[] notesA = { 500, 200, 100, 50, 20, 10, 5, 2, 1 };
        GiveCash(withdrawAmount, notesA);

        Console.WriteLine("\nScenario B");
        int[] notesB = { 200, 100, 50, 20, 10, 5, 2, 1 };
        GiveCash(withdrawAmount, notesB);

        Console.WriteLine("\nScenario C");
        int[] notesC = { 200, 100, 50, 20 };
        GiveCash(withdrawAmount, notesC);
    }

    static void GiveCash(int amount, int[] availableNotes)
    {
        int balance = amount;
        Dictionary<int, int> cash = new Dictionary<int, int>();

        foreach (int note in availableNotes)
        {
            int noteCount = balance / note;

            if (noteCount > 0)
            {
                cash[note] = noteCount;
                balance -= note * noteCount;
            }
        }

        if (balance != 0)
        {
            Console.WriteLine("Exact amount cannot be given");
            return;
        }

        Console.WriteLine($"Amount: {amount}");

        foreach (var item in cash)
        {
            Console.WriteLine($"{item.Key} x {item.Value}");
        }

        Console.WriteLine($"Total notes used: {CountNotes(cash)}");
    }

    static int CountNotes(Dictionary<int, int> cash)
    {
        int total = 0;

        foreach (int count in cash.Values)
        {
            total += count;
        }

        return total;
    }
}
