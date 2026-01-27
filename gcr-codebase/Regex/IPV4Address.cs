using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string[] testIPs =
        {
            "192.168.1.1",
            "255.255.255.255",
            "0.0.0.0",
            "256.100.50.0",
            "192.168.1",
            "192.168.1.999"
        };

        // Regex for IPv4 (0–255)
        string pattern =
            @"^((25[0-5]|2[0-4]\d|1\d{2}|[1-9]?\d)\.){3}" +
            @"(25[0-5]|2[0-4]\d|1\d{2}|[1-9]?\d)$";

        foreach (string ip in testIPs)
        {
            bool isValid = Regex.IsMatch(ip, pattern);
            Console.WriteLine($"{ip} -> {(isValid ? "Valid" : "Invalid")}");
        }
    }
}
