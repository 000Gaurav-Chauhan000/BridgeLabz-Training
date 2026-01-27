using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class TodoAttribute : Attribute
{
    public string Task { get; }
    public string AssignedTo { get; }
    public string Priority { get; }

    public TodoAttribute(string task, string assignedTo, string priority = "MEDIUM")
    {
        Task = task;
        AssignedTo = assignedTo;
        Priority = priority;
    }
}

class Project
{
    [Todo("Implement login", "Alice", "HIGH")]
    public void Login() { }

    [Todo("Add search feature", "Bob")]
    public void Search() { }

    [Todo("Optimize performance", "Charlie", "LOW")]
    public void Optimize() { }
}

class Program
{
    static void Main()
    {
        foreach (var method in typeof(Project).GetMethods(BindingFlags.Public | BindingFlags.Instance))
        {
            var attr = (TodoAttribute)Attribute.GetCustomAttribute(method, typeof(TodoAttribute));
            if (attr != null)
            {
                Console.WriteLine($"Method: {method.Name}, Task: {attr.Task}, AssignedTo: {attr.AssignedTo}, Priority: {attr.Priority}");
            }
        }
    }
}
