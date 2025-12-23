using System;
class OddEven
{
    static void Main()
    {
        Console.WriteLine("Enter a number : ");

        int number = Convert.ToInt16(Console.ReadLine());

        for (int i = 0; i<=number; i++){
            if (i % 2 == 0)
            {
                Console.WriteLine(i);                
            }
        }
    }
}