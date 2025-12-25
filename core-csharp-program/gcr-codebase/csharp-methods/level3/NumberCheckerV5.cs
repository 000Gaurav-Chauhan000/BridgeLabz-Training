using System;

class NumberCheckerV5{
    static bool IsPrime(int n){
        if (n <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
            if (n % i == 0) return false;
        return true;
    }

    static bool IsNeon(int n){
        int sq = n * n, sum = 0;
        while (sq != 0) { sum += sq % 10; sq /= 10; }
        return sum == n;
    }

    static bool IsSpy(int n){
        int sum = 0, prod = 1;
        while (n != 0){
            int d = n % 10;
            sum += d;
            prod *= d;
            n /= 10;
        }
        return sum == prod;
    }

    static bool IsAutomorphic(int n){
        return (n * n).ToString().EndsWith(n.ToString());
    }

    static bool IsBuzz(int n){
        return (n % 7 == 0 || n % 10 == 7);
    }

    static void Main(){

        Console.Write("enter number : ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("prime: " + IsPrime(n));
        Console.WriteLine("neon: " + IsNeon(n));
        Console.WriteLine("spy: " + IsSpy(n));
        Console.WriteLine("automorphic: " + IsAutomorphic(n));
        Console.WriteLine("buzz: " + IsBuzz(n));
    }
}
