using System;

namespace EmployeeWagesTracker
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public bool IsPresent { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Id: {Id}, Salary: {Salary}, IsPresent : {IsPresent}";
        }
    }
}
