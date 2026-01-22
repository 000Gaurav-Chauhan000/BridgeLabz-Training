using System;
using System.IO;

class ImageByteArrayStream
{
    static void Main()
    {
        string path = @"C:\Users\gaurav\Desktop\VisualStudioProjects\Collections\";
        string sourceImage = path + "input.jpg";
        string outputImage = path + "output.jpg";

        try
        {
            // Read image into byte array
            byte[] imageBytes = File.ReadAllBytes(sourceImage);

            // Write byte array back to image using MemoryStream
            using (MemoryStream ms = new MemoryStream(imageBytes))
            using (FileStream fs = new FileStream(outputImage, FileMode.Create, FileAccess.Write))
            {
                ms.WriteTo(fs);
            }

            // Verify both files are identical
            bool isSame = CompareFiles(sourceImage, outputImage);
            Console.WriteLine(isSame
                ? "Image copied successfully. Files are identical."
                : "Files are NOT identical.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("IO Error: " + ex.Message);
        }
    }

    static bool CompareFiles(string file1, string file2)
    {
        byte[] f1 = File.ReadAllBytes(file1);
        byte[] f2 = File.ReadAllBytes(file2);

        if (f1.Length != f2.Length)
            return false;

        for (int i = 0; i < f1.Length; i++)
        {
            if (f1[i] != f2[i])
                return false;
        }

        return true;
    }
}
