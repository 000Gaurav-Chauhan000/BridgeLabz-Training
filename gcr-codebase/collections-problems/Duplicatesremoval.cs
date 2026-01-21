using System;
using System.Collections.Generic;

class RemoveDuplicates
{
    public static List<T> RemoveDuplicatesAlgo<T>(List<T> list)
    {
        HashSet<T> seen = new HashSet<T>();
        List<T> result = new List<T>();

        foreach (T item in list)
        {
            if (seen.Add(item))   
                result.Add(item);
        }

        return result;
    }

    static void Main()
    {
        List<int> input = new List<int> { 3, 1, 2, 2, 3, 4 };
        List<int> output = RemoveDuplicatesAlgo(input);

        Console.WriteLine(string.Join(", ", output)); 
    }
}
