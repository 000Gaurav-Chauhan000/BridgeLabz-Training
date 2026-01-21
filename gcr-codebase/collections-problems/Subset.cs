using System;
using System.Collections.Generic;

class SubsetCheck
{
    public static bool IsSubsetAlgo<T>(HashSet<T> subset, HashSet<T> superset)
    {
        return subset.IsSubsetOf(superset);
    }

    static void Main()
    {
        HashSet<int> set1 = new HashSet<int> { 2, 3 };
        HashSet<int> set2 = new HashSet<int> { 1, 2, 3, 4 };

        Console.WriteLine(IsSubsetAlgo(set1, set2)); 
    }
}
