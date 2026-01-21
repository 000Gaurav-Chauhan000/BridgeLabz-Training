
using System;
using System.Collections.Generic;

class HospitalTriage
{
    public static void SimulateTriageAlgo()
    {
        // Tuple<PatientName, Severity>
        var patients = new List<(string Name, int Severity)>
        {
            ("John", 3),
            ("Alice", 5),
            ("Bob", 2)
        };
        PriorityQueue<string, int> pq = new PriorityQueue<string, int>();

        foreach (var p in patients)
            pq.Enqueue(p.Name, -p.Severity);

        Console.WriteLine("Treatment Order:");
        while (pq.Count > 0)
        {
            Console.WriteLine(pq.Dequeue());
        }
    }
    static void Main()
    {
        SimulateTriageAlgo();
    }
}
