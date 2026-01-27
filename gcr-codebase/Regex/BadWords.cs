using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = "This is a damn bad example with some stupid words.";

        // List of bad words
        string[] badWords = { "damn", "stupid" };

        // Build regex pattern: \b(damn|stupid)\b
        string pattern = $@"\b({string.Join("|", badWords)})\b";

        string output = Regex.Replace(
            input,
            pattern,
            "****",
            RegexOptions.IgnoreCase
        );

        Console.WriteLine("Original Text:");
        Console.WriteLine(input);

        Console.WriteLine();
        Console.WriteLine("Censored Text:");
        Console.WriteLine(output);
    }
}
