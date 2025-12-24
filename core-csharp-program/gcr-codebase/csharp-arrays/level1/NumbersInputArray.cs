using System;

class NumbersInputArray{
    static void Main(){

        int[] numbers = new int[10];
        int total = 0.0;
        int index = 0;

        while (true)
        {
            Console.Write("Enter a number: ");
            int input = Convert.ToInt32(Console.ReadLine());

            if (input <= 0)
                break;

            if (index == 10)
                break;

            numbers[index] = input;
            index++;
        }

        for (int i = 0; i < index; i++){

            Console.WriteLine(numbers[i]);
            total += numbers[i];
        }

        Console.WriteLine("Sum of the numbers is : " +total);
    }
}
