using System;

class TwoNumbers{
    static void Main(){

        Console.WriteLine("Enter 1st number : ");

        int num1 = Convert.ToInt32(Console.ReadLine());

         Console.WriteLine("Enter 2nd number : ");

        int num2 = Convert.ToInt32(Console.ReadLine());

        int quotient = num1/num2;
        int rem = num1%num2;

        Console.WriteLine("The Quotient and remainder of the two numbere " + num1 + " and "+ num2 + " are " + quotient + " and " + rem);
    }
}