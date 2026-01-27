using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class ImportantMethodAttribute : Attribute
{
}

class MyApp
{
    [ImportantMethod]
    public void Launch()
    {
        Console.WriteLine("Launching app...");
    }

    public void Helper()
    {
        Console.WriteLine("Helper method running");
    }
}

class Program
{
    static void Main()
    {
        MyApp app = new MyApp();
        app.Launch();
        app.Helper();

        foreach (var method in typeof(MyApp).GetMethods(BindingFlags.Public | BindingFlags.Instance))
        {
            if (Attribute.IsDefined(method, typeof(ImportantMethodAttribute)))
            {
                Console.WriteLine($"{method.Name} is marked as important");
            }
        }
    }
}
