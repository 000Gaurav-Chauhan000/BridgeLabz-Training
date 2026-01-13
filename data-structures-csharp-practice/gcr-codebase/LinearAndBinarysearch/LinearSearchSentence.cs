using System;

class LinearSearchSentence
{
    static void Main()
    {
        string[] sentences =
        {
            "The same old Monk",
            "Life is meaningless and we all are going to die",
            "If there is a god, then it's either dead or afraid.",
            "The goddess of Love blesses the fast rather than pure"
        };

        string word = "search";

        int index = FindSentenceWithWordAlgo(sentences, word);

        if (index != -1)
            Console.WriteLine($"Word found in sentence at index {index}: {sentences[index]}");
        else
            Console.WriteLine("Word not found in any sentence.");
    }

    static int FindSentenceWithWordAlgo(string[] sentences, string word)
    {
        for (int i = 0; i < sentences.Length; i++)
        {
            if (sentences[i]
                .Contains(word, StringComparison.OrdinalIgnoreCase))
            {
                return i;
            }
        }
        return -1;
    }
}
