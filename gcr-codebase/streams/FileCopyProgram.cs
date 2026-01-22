using System;
using System.IO;
using System.Text;

class FileCopyProgram
{
    static void Main()
    {
        string path = @"C:\Users\gaurav\Desktop\VisualStudioProjects\Collections\";
        string sourceFile = path + "sample.txt";
        string destinationFile = path + "OperandFile.txt";

        try
        {
            if (!File.Exists(sourceFile))
            {
                Console.WriteLine("Source file does not exist.");
                return;
            }

            using (FileStream fsRead = new FileStream(sourceFile, FileMode.Open, FileAccess.Read))
            using (FileStream fsWrite = new FileStream(destinationFile, FileMode.Create, FileAccess.Write))
            {
                byte[] buffer = new byte[fsRead.Length];
                fsRead.Read(buffer, 0, buffer.Length);
                fsWrite.Write(buffer, 0, buffer.Length);
            }

            Console.WriteLine("File copied successfully.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("IO Error: " + ex.Message);
        }
    }
}
