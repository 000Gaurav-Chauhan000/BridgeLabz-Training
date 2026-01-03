using System;

class CourseManager{
    string courseName;
    int duration;
    double fee;
    static string instituteName = "ABC Institute";

    public Course(string name, int duration, double fee){
        this.courseName = name;
        this.duration = duration;
        this.fee = fee;
    }

    public void DisplayCourseDetails(){
        Console.WriteLine("Institute: " + instituteName);
        Console.WriteLine("Course Name: " + courseName);
        Console.WriteLine("Duration: " + duration);
        Console.WriteLine("Fee: " + fee);
    }

    public static void UpdateName(string name){
        instituteName = name;
    }
      static void Main(){
        
        Course.UpdateName("Tech Learning Hub");

        Course c1 = new Course("C# Programming", 3, 12000);
        Course c2 = new Course("Java Basics", 4, 10000);

        c1.DisplayCourseDetails();
        Console.WriteLine();

        c2.DisplayCourseDetails();
    }
}