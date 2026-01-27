using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string text = "The Eiffel Tower is in Paris and the Statue of Liberty is in New York.";

        // Regex: word starting with capital letter followed by lowercase letters
        string pattern = @"\b[A-Z][a-z]*\b";

        MatchCollection matches = Regex.Matches(text, pattern);

        List<string> result = new List<string>();

        foreach (Match match in matches)
        {
            result.Add(match.Value);
        }

        Console.WriteLine("Capitalized Words:");
        Console.WriteLine(string.Join(", ", result));
    }
}
