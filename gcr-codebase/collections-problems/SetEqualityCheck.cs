using System;
using System.Collections.Generic;

class SetEqualityCheck
{
    public static bool AreSetsEqualAlgo<T>(HashSet<T> set1, HashSet<T> set2)
    {
        return set1.SetEquals(set2);
    }

    static void Main()
    {
        HashSet<int> s1 = new HashSet<int> { 1, 2, 3 };
        HashSet<int> s2 = new HashSet<int> { 3, 2, 1 };

        Console.WriteLine(AreSetsEqualAlgo(s1, s2)); 
    }
}
