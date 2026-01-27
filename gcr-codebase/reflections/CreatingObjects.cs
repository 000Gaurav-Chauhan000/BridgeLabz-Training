using System;
using System.Reflection;
using MyApp;

class Program
{
    static void Main()
    {
        Type type = typeof(Student);

        // Using parameterless constructor
        object student1 = Activator.CreateInstance(type);
        ((Student)student1).Name = "Alice";
        ((Student)student1).Age = 20;
        ((Student)student1).Display();

        // Using parameterized constructor
        ConstructorInfo ctor = type.GetConstructor(new Type[] { typeof(string), typeof(int) });
        object student2 = ctor.Invoke(new object[] { "Bob", 22 });
        ((Student)student2).Display();
    }
}
namespace MyApp
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Student() { }

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Display()
        {
            System.Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}
