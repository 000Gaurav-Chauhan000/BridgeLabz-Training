using System;

class NumberCheckerV2{
    static int CountDigits(int number){
        if (number == 0) return 1;

        int count = 0;
        while (number != 0){
            count++;
            number /= 10;
        }
        return count;
    }

    static int[] StoreDigits(int number){
        int count = CountDigits(number);
        int[] digits = new int[count];

        for (int i = count - 1; i >= 0; i--){
            digits[i] = number % 10;
            number /= 10;
        }
        return digits;
    }

    static int SumOfDigits(int[] digits){
        int sum = 0;
        for (int i = 0; i < digits.Length; i++){
            sum += digits[i];
        }
        return sum;
    }

    static int SumOfSquaresOfDigits(int[] digits){
        int sum = 0;
        for (int i = 0; i < digits.Length; i++){
            sum += (int)Math.Pow(digits[i], 2);
        }
        return sum;
    }

    static bool IsHarshadNumber(int number, int[] digits){
        int sum = SumOfDigits(digits);
        return sum != 0 && number % sum == 0;
    }

    static int[,] DigitFrequency(int[] digits){
        int[,] freq = new int[10, 2];

        for (int i = 0; i < 10; i++){
            freq[i, 0] = i;
            freq[i, 1] = 0;
        }

        for (int i = 0; i < digits.Length; i++){
            freq[digits[i], 1]++;
        }

        return freq;
    }

    static void Main(){
        Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());

        int[] digits = StoreDigits(number);

        Console.WriteLine("count of digits : " + CountDigits(number));
        Console.WriteLine("sum of digits : " + SumOfDigits(digits));
        Console.WriteLine("sum of squares of digits :  " + SumOfSquaresOfDigits(digits));
        Console.WriteLine("Harshad's0 Number : " + IsHarshadNumber(number, digits));

        int[,] frequency = DigitFrequency(digits);

        Console.WriteLine("digit frequency : ");
        for (int i = 0; i < 10; i++){
            if (frequency[i, 1] > 0){
                Console.WriteLine(frequency[i, 0] + " -> " + frequency[i, 1]);
            }
        }
    }
}
