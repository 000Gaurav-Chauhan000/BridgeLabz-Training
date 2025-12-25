
using System;

class Factors{
    static int[] FindFactors(int number){
        int count = 0;
        for(int i = 1; i <= number; i++){
            if (number % i == 0)
                count++;
        }
        int[] factors = new int[count];
        int index = 0;
        for(int i = 1; i <= number; i++){
            if (number % i == 0){
                factors[index] = i;
                index++;
            }
        }

        return factors;
    }

    static int FindSum(int[] factors){
        int sum = 0;
        for (int i = 0; i < factors.Length; i++)
            sum += factors[i];
        return sum;
    }

    static int FindProduct(int[] factors)
    {
        int product = 1;
        for (int i = 0; i < factors.Length; i++)
            product *= factors[i];
        return product;
    }

    static double FindSumOfSquares(int[] factors)
    {
        double sum = 0;
        for (int i = 0; i < factors.Length; i++)
            sum += Math.Pow(factors[i], 2);
        return sum;
    }

    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());

        int[] factors = FindFactors(number);

        Console.WriteLine("Factors:");
        Console.WriteLine(string.Join(", ", factors));

        Console.WriteLine("Sum: " + FindSum(factors));
        Console.WriteLine("Product: " + FindProduct(factors));
        Console.WriteLine("Sum of Squares: " + FindSumOfSquares(factors));
    }
}
