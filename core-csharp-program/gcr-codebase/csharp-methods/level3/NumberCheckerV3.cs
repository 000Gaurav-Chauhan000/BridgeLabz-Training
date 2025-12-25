using System;

class NumberCheckerV3{
    static int CountDigits(int num){
        int count = 0;
        while (num != 0) { count++; num /= 10; }
        return count;
    }

    static int[] StoreDigits(int num){
        int[] digits = new int[CountDigits(num)];
        for (int i = digits.Length - 1; i >= 0; i--){
            digits[i] = num % 10;
            num /= 10;
        }
        return digits;
    }

    static int SumOfDigits(int[] digits){
        int sum = 0;
        foreach (int d in digits) sum += d;
        return sum;
    }

    static int SumOfSquares(int[] digits){
        int sum = 0;
        foreach (int d in digits) sum += (int)Math.Pow(d, 2);
        return sum;
    }

    static bool IsHarshad(int num, int[] digits){
        return num % SumOfDigits(digits) == 0;
    }

    static int[,] DigitFrequency(int[] digits){
        int[,] freq = new int[10, 2];
        for (int i = 0; i < 10; i++) freq[i, 0] = i;
        foreach (int d in digits) freq[d, 1]++;
        return freq;
    }

    static void Main(){
        Console.Write("enter number : ");
        int num = int.Parse(Console.ReadLine());

        int[] digits = StoreDigits(num);

        Console.WriteLine("digit Count : " +CountDigits(num));
        Console.WriteLine("sum of digits : " + SumOfDigits(digits));
        Console.WriteLine("sum of squares : " +SumOfSquares(digits));
        Console.WriteLine("Harshad's :  " +IsHarshad(num, digits));

        int[,] freq = DigitFrequency(digits);
        for (int i = 0; i < 10; i++)
            if (freq[i, 1] > 0)
                Console.WriteLine(i + " - "+freq[i,1]);
    }
}
