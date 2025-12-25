using System;

class EmployeeBonus{
    static int[,] GenerateEmployeeData(int employees){
        int[,] data = new int[employees, 2];
        Random random = new Random();

        for (int i = 0; i < employees; i++){
            data[i, 0] = random.Next(10000, 100000);
            data[i, 1] = random.Next(1, 11);
        }
        return data;
    }

    static double[,] CalculateBonusAndNewSalary(int[,] data){
        int employees = data.GetLength(0);
        double[,] result = new double[employees, 2];

        for (int i = 0; i < employees; i++){
            int salary = data[i, 0];
            int years = data[i, 1];
            double bonusRate = years > 5 ? 0.05 : 0.02;
            double bonus = salary * bonusRate;
            double newSalary = salary + bonus;

            result[i, 0] = newSalary;
            result[i, 1] = bonus;
        }
        return result;
    }

    static void DisplaySummary(int[,] oldData, double[,] newData){
        double totalOldSalary = 0;
        double totalNewSalary = 0;
        double totalBonus = 0;

        Console.WriteLine("Emp\tOldSalary\tYears\tBonus\t\tNewSalary");

        for (int i = 0; i < oldData.GetLength(0); i++){
            int oldSalary = oldData[i, 0];
            int years = oldData[i, 1];
            double bonus = newData[i, 1];
            double newSalary = newData[i, 0];

            totalOldSalary += oldSalary;
            totalNewSalary += newSalary;
            totalBonus += bonus;

            Console.WriteLine((i + 1) + "\t" + oldSalary + "\t\t" + years + "\t" + bonus + "\t" + newSalary);
        }

        Console.WriteLine("\nTotal Old Salary: " + totalOldSalary);
        Console.WriteLine("Total Bonus Paid: " + totalBonus);
        Console.WriteLine("Total New Salary: " + totalNewSalary);
    }

    static void Main()
    {
        int employees = 10;

        int[,] employeeData = GenerateEmployeeData(employees);
        double[,] updatedData = CalculateBonusAndNewSalary(employeeData);
        DisplaySummary(employeeData, updatedData);
    }
}
