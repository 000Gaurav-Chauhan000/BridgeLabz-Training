using System;
using System.IO;

class StudentDataStream
{
    static void Main()
    {
        string filePath = @"C:\Users\gaurav\Desktop\VisualStudioProjects\Collections\student.dat";

        try
        {
            // WRITE DATA
            using (FileStream fsWrite = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            using (BinaryWriter writer = new BinaryWriter(fsWrite))
            {
                writer.Write(101);            // Roll Number
                writer.Write("Gaurav");       // Name
                writer.Write(8.75);           // GPA
            }

            // READ DATA
            using (FileStream fsRead = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            using (BinaryReader reader = new BinaryReader(fsRead))
            {
                int rollNo = reader.ReadInt32();
                string name = reader.ReadString();
                double gpa = reader.ReadDouble();

                Console.WriteLine("Student Details:");
                Console.WriteLine($"Roll No : {rollNo}");
                Console.WriteLine($"Name    : {name}");
                Console.WriteLine($"GPA     : {gpa}");
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("IO Error: " + ex.Message);
        }
    }
}