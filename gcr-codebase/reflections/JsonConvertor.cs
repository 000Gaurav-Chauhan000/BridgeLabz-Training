using System;
using System.Reflection;
using System.Text;

namespace MyApp
{
    public class Person
    {
        private int age;
        public string Name { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            this.age = age;
        }
    }

    public static class JsonConverter
    {
        public static string ToJson(object obj)
        {
            if (obj == null) return "null";

            Type type = obj.GetType();
            StringBuilder sb = new StringBuilder();
            sb.Append("{ ");

            FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            PropertyInfo[] properties = type.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

            bool first = true;

            foreach (var field in fields)
            {
                if (!first) sb.Append(", ");
                sb.Append($"\"{field.Name}\": \"{field.GetValue(obj)}\"");
                first = false;
            }

            foreach (var prop in properties)
            {
                if (!prop.CanRead) continue;
                if (!first) sb.Append(", ");
                sb.Append($"\"{prop.Name}\": \"{prop.GetValue(obj)}\"");
                first = false;
            }

            sb.Append(" }");
            return sb.ToString();
        }
    }

    class Program
    {
        static void Main()
        {
            Person person1 = new Person("Alice", 30);
            Person person2 = new Person("Bob", 25);

            string json1 = JsonConverter.ToJson(person1);
            string json2 = JsonConverter.ToJson(person2);

            Console.WriteLine(json1);
            Console.WriteLine(json2);
        }
    }
}
