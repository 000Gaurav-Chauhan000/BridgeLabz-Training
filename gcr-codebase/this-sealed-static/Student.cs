using System;

class Student{
    public static string UniversityName = "ABC university";
    private static int totalStudents = 0;

    public string Name;
    public string Grade;
    public readonly int RollNumber;

    public Student(string Name, int RollNumber, string Grade){
        this.Name = Name;
        this.RollNumber = RollNumber;
        this.Grade = Grade;
        totalStudents++;
    }

    public static void DisplayTotalStudents(){
        Console.WriteLine(totalStudents);
    }

    public void DisplayStudent(object obj){
        if (obj is Student){
            Console.WriteLine(UniversityName);
            Console.WriteLine(Name);
            Console.WriteLine(RollNumber);
            Console.WriteLine(Grade);
        }
    }

    static void Main(){
        Student s1 = new Student("Huyun kwa", 1, "A");
        Student s2 = new Student("Wu - Jun ", 2, "B");

        s1.DisplayStudent(s1);
        s2.DisplayStudent(s2);

        Student.DisplayTotalStudents();
    }
}
