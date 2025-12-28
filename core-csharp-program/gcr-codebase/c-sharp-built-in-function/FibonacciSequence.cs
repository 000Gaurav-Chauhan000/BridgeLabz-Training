using System;

class FibonacciSequence{
    static void PrintFibonacci(int number){
        int a = 0, b = 1;
        for (int i = 1; i <= number; i++){
            Console.Write(a + " ");
            int temp = a + b;
            a = b;
            b = temp;
        }
    }
    static void Main(){
        Console.WriteLine("Enter the number of fibonacci numbers : ");
        int n = Convert.ToInt32(Console.ReadLine());

        PrintFibonacci(n);
    }
}
