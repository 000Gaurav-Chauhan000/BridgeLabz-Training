namespace EmployeeManagementSystem
{
    public class FullTimeEmployee : Employee, IDepartment
    {
        private string department;

        public FullTimeEmployee(int id, string name, decimal salary)
            : base(id, name, salary)
        {
        }

        public override decimal CalculateSalary()
        {
            return baseSalary;
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
            Console.WriteLine($"Department: {department}");
            Console.WriteLine("Employee Type: Full-Time");
        }
    }
}