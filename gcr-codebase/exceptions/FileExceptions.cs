using System;
using System.IO;

class FileExceptions
{
    static void Main()
    {
        try
        {
            string content = File.ReadAllText("C:\\Users\\name\\Desktop\\VisualStudioProjects");
            Console.WriteLine(content);
        }
        catch (IOException)
        {
            Console.WriteLine("File not found");
        }
    }
}
