using System;
using System.Collections.Generic;
using System.Reflection;

namespace MyApp
{
    public class Student
    {
        private int age;
        public string Name { get; set; }

        public Student() { }

        public Student(string name, int age)
        {
            Name = name;
            this.age = age;
        }

        public void Display()
        {
            Console.WriteLine($"Student Name: {Name}, Age: {age}");
        }
    }

    public static class ObjectMapper
    {
        public static T ToObject<T>(Type clazz, Dictionary<string, object> properties) where T : new()
        {
            T obj = (T)Activator.CreateInstance(clazz);

            foreach (var kvp in properties)
            {
                FieldInfo field = clazz.GetField(kvp.Key, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                if (field != null)
                    field.SetValue(obj, kvp.Value);
                else
                {
                    PropertyInfo prop = clazz.GetProperty(kvp.Key, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                    if (prop != null && prop.CanWrite)
                        prop.SetValue(obj, kvp.Value);
                }
            }

            return obj;
        }
    }

    class Program
    {
        static void Main()
        {
            var properties = new Dictionary<string, object>
            {
                { "Name", "Alice" },
                { "age", 20 }
            };

            Student student = ObjectMapper.ToObject<Student>(typeof(Student), properties);
            student.Display();
        }
    }
}
