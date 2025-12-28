using System;

class LongestWord{
    static void Main(){
        Console.WriteLine("Enter a sentence:");
        string sentence = Console.ReadLine();
        string[] words = sentence.Split(' ');

        string longest = words[0];

        for (int i = 1; i < words.Length; i++){
            if (words[i].Length > longest.Length)    longest = words[i];
        }
        Console.WriteLine("Longest word: " + longest);
    }
}
