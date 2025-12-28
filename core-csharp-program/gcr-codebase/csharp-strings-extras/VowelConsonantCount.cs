using System;

class VowelConsonantCount
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string str = Console.ReadLine().ToLower();
        int vowels = 0;
        int consonants = 0;
        for (int i = 0; i < str.Length; i++){
            char ch = str[i];
            if (ch >= 'a' && ch <= 'z'){
                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                    vowels++;
                else
                    consonants++;
            }
        }

        Console.WriteLine("Vowels: " + vowels);
        Console.WriteLine("Consonants: " + consonants);
    }
}
