using System;
class YearlyBonus
{
    static void Main()
    {
        Console.WriteLine("Enter the years of service : ");
        int years = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter salary: ");
        int salary = Convert.ToInt32(Console.ReadLine());

        if (years > 5){
            salary = salary + (salary*5/100);
        }
        Console.WriteLine(salary);
    }
}