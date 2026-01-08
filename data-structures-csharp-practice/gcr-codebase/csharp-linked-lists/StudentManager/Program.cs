using StudentManager;

class Program
{
    static void Main()
    {
        IStudentList students = new StudentLinkedList();

        students.AddAtBeginning(1, "Zyu-Fang", 20, "A");
        students.AddAtEnd(2, "Kein-Tsang", 21, "B");
        students.AddAtPosition(2, 3, "Karan", 22, "A+");

        Console.WriteLine("\nAll Students:");
        students.Display();

        Console.WriteLine("\nSearch Roll No 2:");
        students.Search(2);

        Console.WriteLine("\nUpdate Grade of Roll No 1:");
        students.UpdateGrade(1, "A+");

        Console.WriteLine("\nDelete Roll No 3:");
        students.DeleteByRollNo(3);

        Console.WriteLine("\nFinal Student List:");
        students.Display();
    }
}
