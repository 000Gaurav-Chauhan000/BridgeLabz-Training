using System;
using System.Reflection;

namespace MyApp
{
    public class Person
    {
        private int age;

        public Person(int age)
        {
            this.age = age;
        }

        public void ShowAge()
        {
            Console.WriteLine($"Age: {age}");
        }
    }

    class Program
    {
        static void Main()
        {
            Person person = new Person(25);
            person.ShowAge();

            Type type = typeof(Person);
            FieldInfo field = type.GetField("age", BindingFlags.NonPublic | BindingFlags.Instance);

            field.SetValue(person, 40);
            int ageValue = (int)field.GetValue(person);

            Console.WriteLine($"Modified Age via Reflection: {ageValue}");
            person.ShowAge();
        }
    }
}
