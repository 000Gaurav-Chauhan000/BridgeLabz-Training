using System;
using System.Collections.Generic;
using System.Text;

class DuplicatesRemoval
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        StringBuilder result = new StringBuilder();
        HashSet<char> seen = new HashSet<char>();

        foreach (char c in input)
        {
            if (!seen.Contains(c))
            {
                seen.Add(c);
                result.Append(c);
            }
        }

        Console.WriteLine("After removing duplicates: " + result.ToString());
    }
}
