using System;
using System.Collections.Generic;

class SetOperations
{
    public static HashSet<T> UnionAlgo<T>(HashSet<T> set1, HashSet<T> set2)
    {
        HashSet<T> union = new HashSet<T>(set1);
        union.UnionWith(set2);
        return union;
    }

    public static HashSet<T> IntersectionAlgo<T>(HashSet<T> set1, HashSet<T> set2)
    {
        HashSet<T> intersection = new HashSet<T>(set1);
        intersection.IntersectWith(set2);
        return intersection;
    }

    public static HashSet<T> SymmetricDifferenceAlgo<T>(HashSet<T> set1, HashSet<T> set2)
    {
        HashSet<T> result = new HashSet<T>(set1);
        result.SymmetricExceptWith(set2);
        return result;
    }

    static void Main()
    {
        HashSet<int> s1 = new HashSet<int> { 1, 2, 3 };
        HashSet<int> s2 = new HashSet<int> { 3, 4, 5 };

        Console.WriteLine("Union: " + string.Join(", ", UnionAlgo(s1, s2)));
        Console.WriteLine("Intersection: " + string.Join(", ", IntersectionAlgo(s1, s2)));
        Console.WriteLine("Symmetric Difference: " + string.Join(", ", SymmetricDifferenceAlgo(s1, s2)));
    }
}
