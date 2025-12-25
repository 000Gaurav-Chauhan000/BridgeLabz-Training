using System;

class Handshake
{
    static void maxHandshake(int n)
    {
        Console.WriteLine("The maximum no. of handshake that can happen among/between "+ n + " students are : "+ ((n * (n - 1)) / 2));
    }
    static void Main()
    {
        Console.WriteLine("Enter the number of students : ");
        int students = int.Parse(Console.ReadLine());

        maxHandshake(students);
    }
}