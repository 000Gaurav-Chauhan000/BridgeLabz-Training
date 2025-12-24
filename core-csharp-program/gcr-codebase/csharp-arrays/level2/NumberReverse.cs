using System;
class NumberReverse{
    static void Main(){
        Console.WriteLine("Please enter a number : ");
        int ogNumber = Convert.ToInt32(Console.ReadLine());
        int number = ogNumber;
        int count = 0;

        while(number != 0){
            count++;
            number/= 10;
        }

        number = ogNumber;

        int[] nums = new int[count];
        int i = 0;

        while(number != 0){
            nums[i] = number%10; 
            number/= 10;
            i++;
        }

        foreach (int k in nums){
            Console.Write(k + " ");
        }
        
    }
}