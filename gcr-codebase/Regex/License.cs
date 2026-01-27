using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        // ---------- License Plate Validation ----------
        Console.WriteLine("License Plate Validation:");

        string[] licensePlates =
        {
            "AB1234",
            "XY0001",
            "A12345",
            "ab1234"
        };

        string licensePattern = @"^[A-Z]{2}\d{4}$";

        foreach (string plate in licensePlates)
        {
            bool isValid = Regex.IsMatch(plate, licensePattern);
            Console.WriteLine($"{plate} -> {(isValid ? "Valid" : "Invalid")}");
        }

        Console.WriteLine();

        // ---------- Hex Color Code Validation ----------
        Console.WriteLine("Hex Color Code Validation:");

        string[] hexColors =
        {
            "#FFA07A",
            "#00ff00",
            "#123ABC",
            "123ABC",
            "#FFF"
        };

        string hexPattern = @"^#[0-9A-Fa-f]{6}$";

        foreach (string color in hexColors)
        {
            bool isValid = Regex.IsMatch(color, hexPattern);
            Console.WriteLine($"{color} -> {(isValid ? "Valid" : "Invalid")}");
        }
    }
}
