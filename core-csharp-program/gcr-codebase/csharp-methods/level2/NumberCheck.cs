using System;

class NumberCheck{
    static bool IsPositive(int num){
        return num >= 0;
    }

    static bool IsEven(int num){

        return num % 2 == 0;
    }

    static int Compare(int a, int b){
        if (a > b) return 1;
        if (a == b) return 0;
        return -1;
    }

    static void Main(){
        int[] numbers = new int[5];

        for (int i = 0; i < numbers.Length; i++){
            Console.WriteLine("Enter number " + (i + 1));
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < numbers.Length; i++){
            
            if (IsPositive(numbers[i])){
                if (IsEven(numbers[i]))    Console.WriteLine(numbers[i] + " is Positive and Even");

                else    Console.WriteLine(numbers[i] + " is Positive and Odd");
            }
            else{
                Console.WriteLine(numbers[i] + " is Negative");
            }
        }

        int result = Compare(numbers[0], numbers[numbers.Length - 1]);

        if(result == 1)    Console.WriteLine("First element is greater than last element");

        else if(result == 0)    Console.WriteLine("First element is equal to last element");
        
        else    Console.WriteLine("First element is less than last element");
    }
}
