using System;

class ForLoop{
    static void Main(){
        Console.WriteLine("Enter a number ");
        int counter = Convert.ToInt32(Console.ReadLine());

        for(int i = counter; i > 0; i--){
            Console.WriteLine(i);
        }
    }
}