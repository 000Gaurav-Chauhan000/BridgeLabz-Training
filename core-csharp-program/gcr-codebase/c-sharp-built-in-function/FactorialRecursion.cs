using System;

class FactorialRecursion{
    static long Factorial(int n){
        if (n == 0) return 1;
        return n * Factorial(n - 1);
    }
    static void Main(){
        Console.WriteLine("Enter a number:");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Factorial: " + Factorial(n));
    }
}