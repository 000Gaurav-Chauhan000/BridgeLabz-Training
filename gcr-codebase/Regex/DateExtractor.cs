using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string text = "The events are scheduled for 12/05/2023, 15/08/2024, and 29/02/2020.";

        // Regex for dd/mm/yyyy format
        string pattern = @"\b\d{2}/\d{2}/\d{4}\b";

        MatchCollection matches = Regex.Matches(text, pattern);

        List<string> dates = new List<string>();

        foreach (Match match in matches)
        {
            dates.Add(match.Value);
        }

        Console.WriteLine("Extracted Dates:");
        Console.WriteLine(string.Join(", ", dates));
    }
}
