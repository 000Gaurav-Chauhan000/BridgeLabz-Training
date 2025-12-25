using System;
class SpringSeason
{
    static bool isSpring(int day ,int month){
        if(( day >= 20 && month == 3) ||
        (month == 4) ||
        (month == 5) ||
        (day <= 20 && month == 6)){
            return true;
        }
        else{
            return false;
        }
    }
    static void Main()
    {
        Console.WriteLine("Enter the day(date) : ");
        int day = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the month : ");
        int month = int.Parse(Console.ReadLine());

        Console.WriteLine("The statement season being spring is "+isSpring(day, month));

    }
}