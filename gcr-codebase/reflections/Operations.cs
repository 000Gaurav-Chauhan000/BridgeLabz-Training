using System;
using System.Reflection;
using MyApp;

class Program
{
    static void Main()
    {
        MathOperations math = new MathOperations();
        Type type = typeof(MathOperations);

        Console.Write("Enter method name (Add/Subtract/Multiply): ");
        string methodName = Console.ReadLine();

        Console.Write("Enter first number: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int b = int.Parse(Console.ReadLine());

        MethodInfo method = type.GetMethod(methodName, BindingFlags.Public | BindingFlags.Instance);

        if (method != null)
        {
            int result = (int)method.Invoke(math, new object[] { a, b });
            Console.WriteLine($"Result of {methodName}: {result}");
        }
        else
        {
            Console.WriteLine("Method not found.");
        }
    }
}

namespace MyApp
{
    public class MathOperations
    {
        public int Add(int a, int b) => a + b;

        public int Subtract(int a, int b) => a - b;

        public int Multiply(int a, int b) => a * b;
    }
}
