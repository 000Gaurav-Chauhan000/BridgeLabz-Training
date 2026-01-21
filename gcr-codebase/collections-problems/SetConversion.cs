using System;
using System.Collections.Generic;

class SetConversion
{
    public static List<int> ConvertToSortedListAlgo(HashSet<int> set)
    {
        List<int> list = new List<int>(set);
        list.Sort();   
        return list;
    }

    static void Main()
    {
        HashSet<int> input = new HashSet<int> { 5, 3, 9, 1 };
        List<int> result = ConvertToSortedListAlgo(input);

        Console.WriteLine(string.Join(", ", result)); // 1, 3, 5, 9
    }
}
