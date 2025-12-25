using System;

class SimpleInterest
{
    static void calculateInterest(int time, double rate, double principal){
        Console.WriteLine("the total simple Interest becomes, "+((principal*time*rate)/100)+" after "+ time +" years.");
    }
    static void Main()
    {
        Console.WriteLine("Enter the time : ");
        int time = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the rate of interest : ");
        double rate = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the principal amount : ");
        double principal = double.Parse(Console.ReadLine());

        SimpleInterest.calculateInterest(time,rate,principal);
    }   
}