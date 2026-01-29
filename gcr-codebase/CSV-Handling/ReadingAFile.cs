using System;
using System.IO;
class ReadingAFile
{
    static void Main()
    {
        string filePath = "C:\\Users\\gaurav\\Desktop\\VisualStudioProjects\\NHK.csv";

        if (!File.Exists(filePath))
        {
            Console.WriteLine("Here ain't no such file");
            return;
        }

        string[] lines = File.ReadAllLines(filePath);

        Console.WriteLine("Anime Records : ");
        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] data = lines[i].Split(',');

            string id = data[0];
            string title = data[1];
            string year = data[2];
            string genre = data[3];
            string rating = data[4];

            Console.WriteLine("-/-/-/-/-/-(❁´◡`❁)/-/-/-/-/-");

            Console.WriteLine($"ID : {id}");
            Console.WriteLine($"Title : {title}");
            Console.WriteLine($"Year : {year}");
            Console.WriteLine($"Genre : {genre}");
            Console.WriteLine($"Rating : {rating}");

            Console.WriteLine("-/-/-/-/-/-(❁´◡`❁)/-/-/-/-/-");
        }
    }
}