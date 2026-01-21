using System;
using System.Collections.Generic;

class FrequencyCounter
{
    public static Dictionary<string, int> CountFrequencyAlgo(List<string> list)
    {
        Dictionary<string, int> freq = new Dictionary<string, int>();

        foreach (string item in list)
        {
            if (freq.ContainsKey(item))
                freq[item]++;
            else
                freq[item] = 1;
        }

        return freq;
    }

    static void Main()
    {
        List<string> input = new List<string>
        {
            "apple", "banana", "apple", "orange","orange"
        };

        Dictionary<string, int> result = CountFrequencyAlgo(input);

        foreach (var kv in result)
            Console.WriteLine($"{kv.Key} : {kv.Value}");
    }
}
