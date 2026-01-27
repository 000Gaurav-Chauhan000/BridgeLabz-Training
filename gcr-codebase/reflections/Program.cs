using System;
using System.Reflection;

class Program
{
    static void Main()
    {
        Console.Write("Enter class name (with namespace): ");
        string className = Console.ReadLine();

        Type t = Type.GetType(className);
        if (t == null)
        {
            Console.WriteLine("Class not found.");
            return;
        }

        Console.WriteLine("\nMethods:");
        foreach (MethodInfo method in t.GetMethods())
        {
            Console.WriteLine(method.Name);
        }

        Console.WriteLine("\nFields:");
        foreach (FieldInfo field in t.GetFields())
        {
            Console.WriteLine(field.Name);
        }

        Console.WriteLine("\nConstructors:");
        foreach (ConstructorInfo ctor in t.GetConstructors())
        {
            Console.WriteLine(ctor.ToString());
        }
    }
}
