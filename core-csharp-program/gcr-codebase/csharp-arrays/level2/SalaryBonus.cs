using System;

class SalaryBonus{
    static void Main(){
        int size = 10;

        double[] salary = new double[size];
        double[] years = new double[size];
        double[] bonus = new double[size];
        double[] newSalary = new double[size];

        double totalBonus = 0;

        double totalOldSalary = 0;

        double totalNewSalary = 0;

        for (int i = 0; i < size; i++){
            Console.WriteLine("Employee " + (i + 1));

            Console.Write("Enter salary: ");
            double sal = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter years of service: ");
            double yrs = Convert.ToDouble(Console.ReadLine());
              salary[i] = sal;
              years[i] = yrs;
        }

        for (int i = 0; i < size; i++)
        {
            if (years[i] > 5)
                bonus[i] = salary[i] * 0.05;
            else
                bonus[i] = salary[i] * 0.02;

            newSalary[i] = salary[i] + bonus[i];

            totalBonus += bonus[i];
            totalOldSalary += salary[i];
            totalNewSalary += newSalary[i];
        }
        Console.WriteLine("Total old salary  : " + totalOldSalary);
        Console.WriteLine("Total bonus : " + totalBonus);
        Console.WriteLine("Total new salary  : " + totalNewSalary);
    }
}
