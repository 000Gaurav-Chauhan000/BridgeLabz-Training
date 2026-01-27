using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Field)]
class MaxLengthAttribute : Attribute
{
    public int Value { get; }
    public MaxLengthAttribute(int value)
    {
        Value = value;
    }
}

class User
{
    [MaxLength(10)]
    public string Username;

    public User(string username)
    {
        var field = typeof(User).GetField(nameof(Username));
        var attr = (MaxLengthAttribute)Attribute.GetCustomAttribute(field, typeof(MaxLengthAttribute));

        if (attr != null && username.Length > attr.Value)
            throw new ArgumentException($"Username cannot exceed {attr.Value} characters.");

        Username = username;
    }
}

class Program
{
    static void Main()
    {
        try
        {
            User u1 = new User("Alice");  
            Console.WriteLine(u1.Username);

            User u2 = new User("LongUsername123");  
            Console.WriteLine(u2.Username);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
