using System;
using System.Collections.Generic;

class InvertDictionary
{
    public static Dictionary<V, List<K>> InvertMapAlgo<K, V>(Dictionary<K, V> dict)
    {
        Dictionary<V, List<K>> inverted = new Dictionary<V, List<K>>();

        foreach (var kv in dict)
        {
            V value = kv.Value;
            K key = kv.Key;

            if (!inverted.ContainsKey(value))
                inverted[value] = new List<K>();

            inverted[value].Add(key);
        }

        return inverted;
    }

    static void Main()
    {
        Dictionary<string, int> input = new Dictionary<string, int>
        {
            { "A", 1 },
            { "B", 2 },
            { "C", 1 }
        };

        var inverted = InvertMapAlgo(input);

        foreach (var kv in inverted)
            Console.WriteLine($"{kv.Key} : [{string.Join(", ", kv.Value)}]");
    }
}
