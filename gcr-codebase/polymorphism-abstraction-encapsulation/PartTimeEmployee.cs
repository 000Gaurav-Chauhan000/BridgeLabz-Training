namespace EmployeeManagementSystem
{
    public class PartTimeEmployee : Employee, IDepartment
    {
        private int hoursWorked;
        private string department;

        public PartTimeEmployee(int id, string name, decimal hourlyRate, int hoursWorked)
            : base(id, name, hourlyRate)
        {
            this.hoursWorked = hoursWorked;
        }

        public override decimal CalculateSalary()
        {
            return baseSalary * hoursWorked;
        }

        public void AssignDepartment(string departmentName)
        {
            department = departmentName;
        }

        public string GetDepartmentDetails()
        {
            return department;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Hours Worked: {hoursWorked}");
            Console.WriteLine($"Department: {department}");
            Console.WriteLine("Employee Type: Part-Time");
        }
    }
}