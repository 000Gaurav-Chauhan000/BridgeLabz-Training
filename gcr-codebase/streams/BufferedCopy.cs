using System;
using System.Diagnostics;
using System.IO;

class BufferedCopy
{
    static void Main()
    {
        string path = @"C:\Users\gaurav\Desktop\VisualStudioProjects\Collections\";

        string source = path + "OperandFile.txt";      // source file
        string normalCopy = path + "NormalCopy.txt";
        string bufferedCopy = path + "BufferedCopy.txt";

        if (!File.Exists(source))
        {
            Console.WriteLine("Source file not found!");
            return;
        }

        CopyWithFileStream(source, normalCopy);
        CopyWithBufferedStream(source, bufferedCopy);
    }

    static void CopyWithFileStream(string source, string destination)
    {
        byte[] buffer = new byte[4096];
        Stopwatch sw = Stopwatch.StartNew();

        using (FileStream fsRead = new FileStream(source, FileMode.Open, FileAccess.Read))
        using (FileStream fsWrite = new FileStream(destination, FileMode.Create, FileAccess.Write))
        {
            int bytesRead;
            while ((bytesRead = fsRead.Read(buffer, 0, buffer.Length)) > 0)
            {
                fsWrite.Write(buffer, 0, bytesRead);
            }
        }

        sw.Stop();
        Console.WriteLine($"Normal FileStream Time: {sw.ElapsedMilliseconds} ms");
    }

    static void CopyWithBufferedStream(string source, string destination)
    {
        byte[] buffer = new byte[4096];
        Stopwatch sw = Stopwatch.StartNew();

        using (FileStream fsRead = new FileStream(source, FileMode.Open, FileAccess.Read))
        using (FileStream fsWrite = new FileStream(destination, FileMode.Create, FileAccess.Write))
        using (BufferedStream bsRead = new BufferedStream(fsRead))
        using (BufferedStream bsWrite = new BufferedStream(fsWrite))
        {
            int bytesRead;
            while ((bytesRead = bsRead.Read(buffer, 0, buffer.Length)) > 0)
            {
                bsWrite.Write(buffer, 0, bytesRead);
            }
        }

        sw.Stop();
        Console.WriteLine($"BufferedStream Time: {sw.ElapsedMilliseconds} ms");
    }
}
