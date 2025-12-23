using System;
class SpringSeason{
    static void Main(){
    
    Console.WriteLine("Enter the month :");
    int month = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter the day :");
    int day = Convert.ToInt32(Console.ReadLine());

    if((month == 3 && day >= 20) ||
            (month == 4) ||
            (month == 5) ||
            (month == 6 && day <= 20)){
        Console.WriteLine("This is spring season");
    }
    else{
        Console.WriteLine("This is not spring");
    }

    }
}