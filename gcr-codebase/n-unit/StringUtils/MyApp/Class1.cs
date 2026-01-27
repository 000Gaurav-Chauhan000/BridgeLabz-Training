using System;

namespace MyApp
{
    public class StringUtils
    {
        // Reverse a string
        public string Reverse(string str)
        {
            if (str == null) return null;

            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        // Check if string is palindrome
        public bool IsPalindrome(string str)
        {
            if (str == null) return false;

            string reversed = Reverse(str);
            return string.Equals(str, reversed, StringComparison.OrdinalIgnoreCase);
        }

        // Convert string to uppercase
        public string ToUpperCase(string str)
        {
            return str?.ToUpper();
        }
    }
}
