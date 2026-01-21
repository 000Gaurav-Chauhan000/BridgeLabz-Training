using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

class WordFrequencyCounter
{
    public static Dictionary<string, int> CountWordFrequencyAlgo(string filePath)
    {
        Dictionary<string, int> freq = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

        foreach (string line in File.ReadLines(filePath))
        {
            string[] words = Regex.Split(line, @"\W+");

            foreach (string word in words)
            {
                if (string.IsNullOrWhiteSpace(word))
                    continue;

                string lowerWord = word.ToLower();
                if (freq.ContainsKey(lowerWord))
                    freq[lowerWord]++;
                else
                    freq[lowerWord] = 1;
            }
        }

        return freq;
    }

    static void Main()
    {
        string filePath = "sample.txt"; 
        var result = CountWordFrequencyAlgo(filePath);

        foreach (var kv in result)
            Console.WriteLine($"{kv.Key} : {kv.Value}");
    }
}
