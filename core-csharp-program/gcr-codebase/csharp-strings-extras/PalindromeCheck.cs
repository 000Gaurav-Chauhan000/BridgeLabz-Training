using System;

class PalindromeCheck{
    static void Main()
{
        Console.WriteLine("Enter a string:");
        string str = Console.ReadLine();
        string reverse = "";

        for (int i = str.Length - 1; i >= 0; i--)        {
            reverse += str[i];
        }
        if (str.Equals(reverse))    Console.WriteLine("Palindrome");
    
        else    Console.WriteLine("Not a Palindrome");
    }
}
