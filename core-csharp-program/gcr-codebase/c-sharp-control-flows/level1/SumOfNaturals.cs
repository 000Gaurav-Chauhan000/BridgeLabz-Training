using System;
class SumOfNaturals{
    static void Main(){

        Console.WriteLine("Enter a number : ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number < 0)
        {
            Console.WriteLine("Please enter a positive number");
            return;
        }
        int n = number;
        
        int sum = 0;

        while(number != 0){         
            
            sum += number;
            number--;        }

        int sum2 = n*(n+1)/2;

        Console.WriteLine("The result for both the calculation is : "+ (sum2 == sum));
    }
}