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
                emp.IsPresent = Convert.ToBoolean(random.Next(0, 2));
            }
        }
        public void ShowAttendence(){
           foreach (Employee emp in employees)
            {
                Console.WriteLine(emp);
            }
        }
    }
}