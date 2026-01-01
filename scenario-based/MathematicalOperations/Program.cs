using MathematicalOperations;
using System;
class Program{
    static void Main() {
        int number = 10;
        int number2 = 15;
        Console.WriteLine(GCDofNumber.calculateGCD(number, number2));
        Console.WriteLine(Factorial.FactorialOf(number));
        Console.WriteLine(Fibonacci.FibonacciOf(number));
        Console.WriteLine(PrimeNumber.IsPrime(number2));

    }
    
}