using System;

namespace EmployeeWagesTracker{

    internal class EmployeeUtilityImpl : IEmployee{

        //Version 1.0

        Employee[] employees=new Employee[2];
        int count= 0;
        public void AddEmployee()
        {
            if (count >= employees.Length)
            {
                Console.WriteLine("Employee storage is full. Cannot add more employees.");
                return;
            }

            Employee employee = new Employee();

            Console.WriteLine("Enter Id : ");
            employee.Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Name : ");
            employee.Name = Console.ReadLine();

            Console.WriteLine("Enter Salary : ");
            employee.Salary = Convert.ToDouble(Console.ReadLine());

            employees[count++] = employee;

            Console.WriteLine("Employee added successfully.");
        }

        public void MarkAttendence()
        {
            Random random = new Random();

            foreach (Employee emp in employees)
            {
                emp.AttendanceType = random.Next(0, 3); 
            }
        }

        public void ShowAttendence(){
           foreach (Employee emp in employees)
            {
                Console.WriteLine(emp);
            }
        }

        //Version 2.0

        const int WagePerHour = 20;
        const int FullDayHour = 8;
        const int PartTimeHour = 8;

        public void CalculateDailyWage()
        {
            foreach (Employee emp in employees)
            {
                switch (emp.AttendanceType)
                {
                    case 1: 
                        emp.DailyWage = WagePerHour * FullDayHour;
                        break;

                    case 2: 
                        emp.DailyWage = WagePerHour * PartTimeHour;
                        break;

                    default: 
                        emp.DailyWage = 0;
                        break;
                }
            }
        }

        const int WorkingDaysPerMonth = 20;

        public void CalculateMonthlyWage()
        {
            if (count == 0)
            {
                Console.WriteLine("No employees available.");
                return;
            }

            foreach (var emp in employees)
            {
                if (emp == null) continue;

                emp.MonthlyWage = emp.DailyWage * WorkingDaysPerMonth;
            }

            Console.WriteLine("Monthly wage calculated successfully.");
        }

        const int MaxWorkingDays = 20;
        const int MaxWorkingHours = 100;

        public void CalculateMonthlyWageWithCondition()
        {
            if (count == 0)
            {
                Console.WriteLine("No employees available.");
                return;
            }

            Random random = new Random();

            for (int i = 0; i < count; i++)
            {
                int totalDays = 0;
                int totalHours = 0;
                int totalWage = 0;

                while (totalDays < MaxWorkingDays && totalHours < MaxWorkingHours)
                {
                    int attendance = random.Next(0, 3); 
                    int hoursWorked = 0;

                    switch (attendance)
                    {
                        case 1: 
                            hoursWorked = FullDayHour;
                            break;

                        case 2: 
                            hoursWorked = PartTimeHour;
                            break;

                        default: 
                            hoursWorked = 0;
                            break;
                    }

                    totalHours += hoursWorked;
                    totalWage += hoursWorked * WagePerHour;
                    totalDays++;
                }

                employees[i].MonthlyWage = totalWage;
            }

            Console.WriteLine("Monthly wage calculated with conditions.");
        }

    }
}