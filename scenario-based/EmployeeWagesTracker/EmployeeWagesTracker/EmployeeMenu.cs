using System;

namespace EmployeeWagesTracker
{
    sealed class EmployeeMenu
    {
        private IEmployee IEmp;

        public EmployeeMenu()
        {
            IEmp = new EmployeeUtilityImpl();
        }

        //Version 4.0 Changes
        public void EmployeeChoices()
        {
            int choice;

            do
            {
                Console.WriteLine("\n\n--- Employee Wage Tracker Menu ---");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Mark Attendance");
                Console.WriteLine("3. Calculate Daily Wage");
                Console.WriteLine("4. Show Attendance");
                Console.WriteLine("0. Exit");

                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        IEmp.AddEmployee();
                        break;

                    case 2:
                        IEmp.MarkAttendence();
                        break;

                    case 3:
                        IEmp.CalculateDailyWage();
                        break;

                    case 4:
                        IEmp.ShowAttendence();
                        break;

                    case 0:
                        Console.WriteLine("Exiting application...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }

            } while (choice != 0);
        }
    }
}
