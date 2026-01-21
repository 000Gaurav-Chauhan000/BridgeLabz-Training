using System;
using System.Collections.Generic;

class InsurancePolicyManagement
{
    static void HashSetExample()
    {
        HashSet<string> policies = new HashSet<string>();
        policies.Add("POL123");
        policies.Add("POL456");
        policies.Add("POL123"); // Duplicate ignored

        Console.WriteLine("HashSet Lookup:");
        Console.WriteLine(policies.Contains("POL123")); // True
        Console.WriteLine(string.Join(", ", policies));
    }
        static void LinkedHashSetExample()
    {
        HashSet<string> set = new HashSet<string>();
        LinkedList<string> orderedPolicies = new LinkedList<string>();

        void AddPolicy(string policy)
        {
            if (set.Add(policy)) // Only add if not exists
                orderedPolicies.AddLast(policy);
        }

        AddPolicy("POL123");
        AddPolicy("POL456");
        AddPolicy("POL123"); // ignored

        Console.WriteLine("\nLinkedHashSet (Insertion Order):");
        foreach (var p in orderedPolicies)
            Console.WriteLine(p);
    }
        class Policy
    {
        public string Id { get; set; }
        public DateTime Expiry { get; set; }
        public override string ToString() => $"{Id} (Expiry: {Expiry:yyyy-MM-dd})";
    }

    class ExpiryComparer : IComparer<Policy>
    {
        public int Compare(Policy x, Policy y)
        {
            int cmp = x.Expiry.CompareTo(y.Expiry);
            return cmp != 0 ? cmp : x.Id.CompareTo(y.Id); // handle duplicates
        }
    }

    static void SortedSetExample()
    {
        SortedSet<Policy> sortedPolicies = new SortedSet<Policy>(new ExpiryComparer())
        {
            new Policy { Id = "POL123", Expiry = new DateTime(2026, 5, 10) },
            new Policy { Id = "POL456", Expiry = new DateTime(2026, 2, 15) },
            new Policy { Id = "POL789", Expiry = new DateTime(2026, 5, 10) },
        };

        Console.WriteLine("\nSortedSet (by Expiry Date):");
        foreach (var p in sortedPolicies)
            Console.WriteLine(p);
    }

    static void Main()
    {
        HashSetExample();
        LinkedHashSetExample();
        SortedSetExample();
    }
}