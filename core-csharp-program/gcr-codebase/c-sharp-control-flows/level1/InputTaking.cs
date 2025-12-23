using System;

class InputTaking{
    static void Main(){

        int sum = 0;
        while(true){
            Console.WriteLine("Enter number : ");

            int a = Convert.ToInt32(Console.ReadLine());

            if(a == 0){ 
                break;
            }
                sum += a;
            
        }
        Console.WriteLine(sum);
    }
}