using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class WordFrequencyCounter
{
    static void Main()
    {
        string filePath = @"C:\Users\gaurav\Desktop\VisualStudioProjects\Collections\TextData.txt";

        try
        {
            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line
                        .ToLower()
                        .Split(new char[] { ' ', '\t', '.', ',', ';', ':', '!', '?', '"', '\'' },
                               StringSplitOptions.RemoveEmptyEntries);

                    foreach (string word in words)
                    {
                        if (wordCount.ContainsKey(word))
                            wordCount[word]++;
                        else
                            wordCount[word] = 1;
                    }
                }
            }

            Console.WriteLine("Top 5 Most Frequent Words:\n");

            foreach (var item in wordCount
                     .OrderByDescending(w => w.Value)
                     .Take(5))
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("IO Error: " + ex.Message);
        }
    }
}
