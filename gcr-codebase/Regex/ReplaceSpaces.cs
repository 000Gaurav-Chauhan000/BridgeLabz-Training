using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = "This   is    an   example   with   multiple    spaces.";

        // Regex: one or more spaces
        string pattern = @"\s+";

        string output = Regex.Replace(input, pattern, " ");

        Console.WriteLine("Original Text:");
        Console.WriteLine(input);

        Console.WriteLine();
        Console.WriteLine("Modified Text:");
        Console.WriteLine(output);
    }
}
