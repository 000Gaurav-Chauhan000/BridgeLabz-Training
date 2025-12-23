using System;
class SumOfNaturals2{
    static void Main(){

        Console.WriteLine("Enter a number : ");
        int number = Convert.ToInt32(Console.ReadLine());
        int n = number;
        
        int sum = 0;

         if (number < 0)
        {
            Console.WriteLine("Enter a positive number");
            return;
        }

        for(int i =0; i<=number; i++){
            sum+=i;
        }
        Console.WriteLine(sum);

        int sum2 = n*(n+1)/2;
        Console.WriteLine(sum2);

        Console.WriteLine("The result for both the calculation is : "+ (sum2 == sum));
    }
}