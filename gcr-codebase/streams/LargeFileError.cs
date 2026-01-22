using System;
using System.IO;

class LargeFileErrorFilter
{
    static void Main()
    {
        string filePath = @"C:\Users\gaurav\Desktop\VisualStudioProjects\Collections\LargeLog.txt";

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.IndexOf("error", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("IO Error: " + ex.Message);
        }
    }
}
