using System;
using System.IO;
using System.Text;

class UpperToLowerFilter
{
    static void Main()
    {
        string path = @"C:\Users\gaurav\Desktop\VisualStudioProjects\Collections\";
        string sourceFile = path + "InputText.txt";
        string destinationFile = path + "LowercaseOutput.txt";

        try
        {
            using (FileStream fsRead = new FileStream(sourceFile, FileMode.Open, FileAccess.Read))
            using (FileStream fsWrite = new FileStream(destinationFile, FileMode.Create, FileAccess.Write))
            using (BufferedStream bsRead = new BufferedStream(fsRead))
            using (BufferedStream bsWrite = new BufferedStream(fsWrite))
            using (StreamReader reader = new StreamReader(bsRead, Encoding.UTF8))
            using (StreamWriter writer = new StreamWriter(bsWrite, Encoding.UTF8))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    writer.WriteLine(line.ToLower());
                }
            }

            Console.WriteLine("File converted to lowercase successfully.");
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
