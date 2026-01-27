using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string sentence = "This is is a repeated repeated word test.";

        string repeatPattern = @"\b(\w+)\s+\1\b";

        MatchCollection repeatMatches = Regex.Matches(
            sentence,
            repeatPattern,
            RegexOptions.IgnoreCase
        );

        HashSet<string> repeatingWords = new HashSet<string>();

        foreach (Match match in repeatMatches)
        {
            repeatingWords.Add(match.Groups[1].Value);
        }

        Console.WriteLine("Repeating Words:");
        Console.WriteLine(string.Join(", ", repeatingWords));

        Console.WriteLine();

        string text = "My SSN is 123-45-6789.";

        string ssnPattern = @"\b\d{3}-\d{2}-\d{4}\b";

        Match ssnMatch = Regex.Match(text, ssnPattern);

        if (ssnMatch.Success)
        {
            Console.WriteLine($"\"{ssnMatch.Value}\" is valid");
        }
        else
        {
            Console.WriteLine(" Invalid SSN");
        }

        // Extra test
        string invalidSSN = "123456789";
        Console.WriteLine(
            Regex.IsMatch(invalidSSN, ssnPattern)
            ? $" \"{invalidSSN}\" is valid"
            : $" \"{invalidSSN}\" is invalid"
        );
    }
}
