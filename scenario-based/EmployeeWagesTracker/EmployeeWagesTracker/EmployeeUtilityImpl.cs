using System;

namespace EmployeeWagesTracker{

    internal class EmployeeUtilityImpl : IEmployee{

        //Version 1.0

        Employee[] employees=new Employee[2];
        int count= 0;
        public void AddEmployee(){
            for (int i = 0; i < employees.Length; i++) {
               Employee employee = new Employee();
                Console.WriteLine("Enter Id : ");
                employee.Id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Name : ");
                employee.Name = Console.ReadLine();

                Console.WriteLine("Enter Salary : ");
                employee.Salary = Convert.ToDouble(Console.ReadLine());
                employees[count]=employee;
                count++;
            }

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
    }
}