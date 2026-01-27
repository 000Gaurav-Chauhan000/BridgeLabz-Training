using System;
using System.Collections.Generic;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class CacheResultAttribute : Attribute
{
}

class Calculator
{
    private Dictionary<int, int> cache = new Dictionary<int, int>();

    [CacheResult]
    public int Fibonacci(int n)
    {
        if (cache.ContainsKey(n)) return cache[n];

        int result = n <= 1 ? n : Fibonacci(n - 1) + Fibonacci(n - 2);
        cache[n] = result;
        return result;
    }
}

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();
        var method = typeof(Calculator).GetMethod("Fibonacci");

        int[] inputs = { 10, 15, 10, 20 };
        foreach (int n in inputs)
        {
            if (Attribute.IsDefined(method, typeof(CacheResultAttribute)))
            {
                int result = (int)method.Invoke(calc, new object[] { n });
                Console.WriteLine($"Fibonacci({n}) = {result}");
            }
        }
    }
}
