using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        string languageText = "I love Java, Python, and JavaScript, but I haven't tried Go yet.";

        string[] languages = { "Java", "Python", "JavaScript", "Go" };

        string languagePattern = $@"\b({string.Join("|", languages)})\b";

        MatchCollection languageMatches = Regex.Matches(languageText, languagePattern);

        List<string> foundLanguages = new List<string>();

        foreach (Match match in languageMatches)
        {
            foundLanguages.Add(match.Value);
        }

        Console.WriteLine("Extracted Programming Languages:");
        Console.WriteLine(string.Join(", ", foundLanguages));

        Console.WriteLine();

        string currencyText = "The price is $45.99, and the discount is $ 10.50.";

        string currencyPattern = @"\$?\s?\d+\.\d{2}";

        MatchCollection currencyMatches = Regex.Matches(currencyText, currencyPattern);

        List<string> currencies = new List<string>();

        foreach (Match match in currencyMatches)
        {
            currencies.Add(match.Value.Trim());
        }

        Console.WriteLine("Extracted Currency Values:");
        Console.WriteLine(string.Join(", ", currencies));
    }
}
