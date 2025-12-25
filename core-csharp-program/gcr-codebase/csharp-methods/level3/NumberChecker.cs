using System;

class NumberChecker{
    public static int CountDigits(int number){
        int count = 0;
        if (number == 0) return 1;

        while (number != 0){
            count++;
            number /= 10;
        }
        return count;
    }

    public static int[] StoreDigits(int number){
        int count = CountDigits(number);
        int[] digits = new int[count];

        for (int i = count - 1; i >= 0; i--){
            digits[i] = number % 10;
            number /= 10;
        }
        return digits;
    }

    public static bool IsDuckNumber(int[] digits){
        for (int i = 0; i < digits.Length; i++){
            if (digits[i] != 0)    return true;
        }
        return false;
    }

    public static bool IsArmstrongNumber(int original, int[] digits){
        int power = digits.Length;
        int sum = 0;

        for (int i = 0; i < digits.Length; i++){
            sum += (int)Math.Pow(digits[i], power);
        }
        return sum == original;
    }

    public static int[] FindLargestAndSecondLargest(int[] digits){
        int largest = Int32.MinValue;
        int secondLargest = Int32.MinValue;

        for (int i = 0; i < digits.Length; i++){
            if (digits[i] > largest){
                secondLargest = largest;
                largest = digits[i];
            }
            else if (digits[i] > secondLargest && digits[i] != largest){
                secondLargest = digits[i];
            }
        }
        return new int[] { largest, secondLargest };
    }

    public static int[] FindSmallestAndSecondSmallest(int[] digits){
        int smallest = Int32.MaxValue;
        int secondSmallest = Int32.MaxValue;

        for (int i = 0; i < digits.Length; i++){
            if (digits[i] < smallest){
                secondSmallest = smallest;
                smallest = digits[i];
            }
            else if (digits[i] < secondSmallest && digits[i] != smallest){
                secondSmallest = digits[i];
            }
        }
        return new int[] { smallest, secondSmallest };
    }

    static void Main(){
        Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());

        int[] digits = StoreDigits(number);

        Console.WriteLine("Digit Count: " + CountDigits(number));

        Console.Write("Digits: ");
        for (int i = 0; i < digits.Length; i++)
            Console.Write(digits[i] + " ");
        Console.WriteLine();

        Console.WriteLine("Duck Number: " + IsDuckNumber(digits));
        Console.WriteLine("Armstrong Number: " + IsArmstrongNumber(number, digits));

        int[] large = FindLargestAndSecondLargest(digits);
        Console.WriteLine("Largest: " + large[0] + " Second Largest: " + large[1]);

        int[] small = FindSmallestAndSecondSmallest(digits);
        Console.WriteLine("Smallest: " + small[0] + " Second Smallest: " + small[1]);
    }
}