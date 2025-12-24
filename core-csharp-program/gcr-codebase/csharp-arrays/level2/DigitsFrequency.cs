using System;

class DigitsFrequency
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        if (num < 0)
            num = -num;

        int[] freq = new int[10];

        if (num == 0)
            freq[0]++;

        while (num != 0){
            freq[num % 10]++;
            num /= 10;
        }

        Console.WriteLine("Frequencies of different digits are : ");
        for (int i = 0; i < 10; i++){
            Console.WriteLine(i + " occurs - " + freq[i]+ " time(s)");
        }
    }
}
