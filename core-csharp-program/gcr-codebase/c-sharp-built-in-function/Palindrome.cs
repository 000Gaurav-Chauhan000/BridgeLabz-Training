using System;

class Palindrome{
    static bool IsPalindrome(string s){
        int start = 0;
        int end = s.Length - 1;

        while (start < end){
            if (s[start] != s[end])    return false;
            start++;
            end--;
        }
        return true;
    }
    static void Main(){
        Console.WriteLine("Enter a string:");
        string str = Console.ReadLine();

        Console.WriteLine(IsPalindrome(str) ? "Palindrome" : "Not Palindrome");
    }
}
