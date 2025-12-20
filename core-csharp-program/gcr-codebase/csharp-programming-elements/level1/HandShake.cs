using System;

class HandShake
{
    static void Main()
    {
        Console.Write("enter number of students: ");
        int students = Convert.ToInt32(Console.ReadLine());

        int handshakes = (students*(students-1))/2;

        Console.WriteLine("the maximum number of possible handshakes is " + handshakes);
    }
}
