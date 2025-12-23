using System;
class NumberType{
    static void Main(){

        Console.WriteLine("Enter a number : ");

        int num = Convert.ToInt32(Console.ReadLine());

        if(num > 0){
            Console.WriteLine("The number given is positive");
        }
        else if(num < 0){
            Console.WriteLine("The number given is negative");
        }
        else{
            Console.WriteLine("The number given is 0");    
        }
    }
}