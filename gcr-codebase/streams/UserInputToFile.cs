using System;
using System.IO;

class UserInputToFile
{
    static void Main()
    {
        string filePath = @"C:\Users\gaurav\Desktop\VisualStudioProjects\Collections\UserInfo.txt";

        try
        {
            using (StreamReader reader = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                Console.Write("Enter your name: ");
                string name = reader.ReadLine();

                Console.Write("Enter your age: ");
                string age = reader.ReadLine();

                Console.Write("Enter your favorite programming language: ");
                string language = reader.ReadLine();

                writer.WriteLine("---- User Information ----");
                writer.WriteLine($"Name     : {name}");
                writer.WriteLine($"Age      : {age}");
                writer.WriteLine($"Language : {language}");
                writer.WriteLine();
            }

            Console.WriteLine("User information saved successfully.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("IO Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
