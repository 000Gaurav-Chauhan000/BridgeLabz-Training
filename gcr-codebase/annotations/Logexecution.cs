using System;
using System.Diagnostics;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class LogExecutionTimeAttribute : Attribute
{
}

class MyService
{
    [LogExecutionTime]
    public void FastMethod()
    {
        for (int i = 0; i < 1000; i++) { }
    }

    [LogExecutionTime]
    public void SlowMethod()
    {
        for (int i = 0; i < 1000000; i++) { }
    }
}

class Program
{
    static void Main()
    {
        MyService service = new MyService();
        var methods = typeof(MyService).GetMethods(BindingFlags.Public | BindingFlags.Instance);

        foreach (var method in methods)
        {
            if (Attribute.IsDefined(method, typeof(LogExecutionTimeAttribute)))
            {
                Stopwatch sw = Stopwatch.StartNew();
                method.Invoke(service, null);
                sw.Stop();
                Console.WriteLine($"{method.Name} executed in {sw.ElapsedMilliseconds} ms");
            }
        }
    }
}
