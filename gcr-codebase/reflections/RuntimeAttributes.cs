using System;
using System.Reflection;
using MyApp;

namespace MyApp
{
    [AttributeUsage(AttributeTargets.Class)]
    public class AuthorAttribute : Attribute
    {
        public string Name { get; }

        public AuthorAttribute(string name)
        {
            Name = name;
        }
    }
}
namespace MyApp
{
    [Author("John Doe")]
    public class Book
    {
        public string Title { get; set; }
        public Book(string title)
        {
            Title = title;
        }
    }
}

class Program
{
    static void Main()
    {
        Type type = typeof(Book);

        object[] attributes = type.GetCustomAttributes(typeof(AuthorAttribute), false);

        if (attributes.Length > 0)
        {
            AuthorAttribute author = (AuthorAttribute)attributes[0];
            Console.WriteLine($"Author of class {type.Name}: {author.Name}");
        }
        else
        {
            Console.WriteLine("No Author attribute found.");
        }
    }
}
