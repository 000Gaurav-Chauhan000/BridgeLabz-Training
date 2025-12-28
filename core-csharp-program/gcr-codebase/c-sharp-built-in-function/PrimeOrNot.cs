
using System;

class PrimeOrNot{
    static bool IsPrime(int num){
        if (num <= 1) return false;
        for (int i = 2; i <= num / 2; i++)
            if (num % i == 0)    return false;
        return true;
    }

    static void Main(){ 
        Console.WriteLine("Enter a number : ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(IsPrime(n) ? "Prime Number" : "Not a Prime Number");
    }
}
