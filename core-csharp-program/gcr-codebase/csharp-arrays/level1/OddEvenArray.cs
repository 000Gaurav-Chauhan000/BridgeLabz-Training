using System;

class OddEvenArray{
    static void Main(){

        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number <= 0){

            Console.WriteLine("Please enter a natural number");
            return;

        }
        
        int[] even = new int[number / 2 + 1];
        int[] odd = new int[number / 2 + 1];

        int evenIndex = 0;
        int oddIndex = 0;

        for (int i = 1; i <= number; i++){
            if (i % 2 == 0){
                even[evenIndex] = i;
                evenIndex++;
            }
            else{
                odd[oddIndex] = i;
                oddIndex++;
            }
        }
         Console.WriteLine("Even Numbers:");
        for (int i = 0; i < evenIndex; i++){
            Console.Write(even[i] + " ");
        }
        Console.WriteLine("Odd Numbers:");
        for (int i = 0; i < oddIndex; i++){
            Console.Write(odd[i] + " ");
        }
    }
}