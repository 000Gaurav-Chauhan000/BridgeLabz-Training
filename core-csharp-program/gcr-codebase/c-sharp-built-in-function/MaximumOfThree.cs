using System;

class MaximumOfThree{
    static int FindMax(int a, int b, int c){
        int max = a;
        if (b > max) max = b;
        if (c > max) max = c;
        return max;
    }
    static void Main(){
        Console.WriteLine("Enter three numbers:");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Maximum: " + FindMax(a, b, c));
    }
}
