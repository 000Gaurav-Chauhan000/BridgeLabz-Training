using System;

class RocketLaunch{
    static void Main(){

        Console.WriteLine("Enter a number : ");
        int counter = Convert.ToInt32(Console.ReadLine());

        while(counter != 0){

            Console.WriteLine(counter);
            counter--;
        }
    }
}