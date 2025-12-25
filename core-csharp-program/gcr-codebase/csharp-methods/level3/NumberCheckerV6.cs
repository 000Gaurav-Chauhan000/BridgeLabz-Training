using System;

class NumberCheckerV6{
    static int[] Factors(int n){
        int count = 0;
        for (int i = 1; i <= n; i++)    if (n % i == 0) count++;

        int[] f = new int[count];
        int idx = 0;
        for (int i = 1; i <= n; i++)    if (n % i == 0) f[idx++] = i;

        return f;
   }

    static int SumFactors(int[] f){
        int sum = 0;
        for (int i = 0; i < f.Length - 1; i++)    sum += f[i];
        return sum;
    }

    static bool IsPerfect(int n){
        return SumFactors(Factors(n)) == n;
    }

    static bool IsAbundant(int n){
        return SumFactors(Factors(n)) > n;
    }
    static bool IsDeficient(int n){
        return SumFactors(Factors(n)) < n;
    }
    static int Fact(int n){
        int f = 1;
        for (int i = 1; i <= n; i++) f *= i;
        return f;
    }

    static bool IsStrong(int n){
        int temp = n, sum = 0;
        while (temp != 0){
            sum += Fact(temp % 10);
            temp /= 10;
        }
        return sum == n;
    }
        static void Main(){
        Console.Write("enter number: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("perfect : " +IsPerfect(n));
        Console.WriteLine("abundant : "+IsAbundant(n));
        Console.WriteLine("deficient : "+ IsDeficient(n));
        Console.WriteLine("strong : "+IsStrong(n));
    }
}
