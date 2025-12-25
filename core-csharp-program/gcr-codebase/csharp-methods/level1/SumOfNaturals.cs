using System;
class SumOfNaturals{

static int numberSum(int n){

    int sum = 0;
        for(int i = 1; i <= n; i++){
            sum += i;
        }
        return sum;
    }
    static void Main(){
        Console.WriteLine("Enter a number : ");
        int number = int.Parse(Console.ReadLine());
        
        Console.WriteLine("The sum is : "+ numberSum(number));
    }
}
