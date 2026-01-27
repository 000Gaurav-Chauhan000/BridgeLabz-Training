using System.Text.RegularExpressions;

string pattern = @"^[A-Za-z][A-Za-z0-9_]{4,15}$";

bool isValid = Regex.IsMatch("John_1", pattern);
Console.WriteLine(isValid); 
