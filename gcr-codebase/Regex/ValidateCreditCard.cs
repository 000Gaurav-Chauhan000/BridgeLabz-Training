using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string[] cardNumbers =
        {
            "4111111111111111", 
            "5111111111111111", 
            "6111111111111111", 
            "411111111111",     
            "511111111111111a"  
        };

        
        string pattern = @"^(4\d{15}|5\d{15})$";

        foreach (string card in cardNumbers)
        {
            bool isValid = Regex.IsMatch(card, pattern);
            Console.WriteLine($"{card} -> {(isValid ? "Valid" : "Invalid")}");
        }
    }
}
