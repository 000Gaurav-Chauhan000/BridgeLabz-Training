using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "Contact us at support@example.com and info@company.org";

        // Regex pattern for basic email extraction
        string pattern = @"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}\b";

        MatchCollection matches = Regex.Matches(text, pattern);

        Console.WriteLine("Extracted Email Addresses:");

        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
