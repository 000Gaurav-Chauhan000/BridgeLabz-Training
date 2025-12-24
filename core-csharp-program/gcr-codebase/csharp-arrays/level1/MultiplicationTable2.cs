using System;
class MultiplicationTable2{
    static void Main(){

        Console.Write("Choose a number : ");
        int number = Convert.ToInt32(Console.ReadLine());

        int[] table = new int[5];

        for (int i = 1; i <= 5; i++)
        {
            table[i-1] = number * (i+5);
        }

        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine(number + " x " + (i +5) + " = " + table[i-1]);
        }
    }
}
