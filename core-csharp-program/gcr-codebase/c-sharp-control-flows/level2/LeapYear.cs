using System;

class LeapYear{
    static void Main(){
        
        Console.WriteLine("Enter the Year : ");
        int year = Convert.ToInt32(Console.ReadLine());

        
        if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0)){
            Console.WriteLine("Leap Year");
        }
        else{
            Console.WriteLine("Not a Leap Year");
        }
    }
}