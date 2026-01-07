using System;

namespace EmployeeWagesTracker
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public int AttendanceType { get; set; }

        public int DailyWage { get; set; }

        public override string ToString()
        {
            string status = AttendanceType switch
            {
                1 => "Full Time",
                2 => "Part Time",
                _ => "Absent"
            };

            return $"Id: {Id}, Name: {Name}, Status: {status}, Daily Wage: {DailyWage}";
        }
    }
}
