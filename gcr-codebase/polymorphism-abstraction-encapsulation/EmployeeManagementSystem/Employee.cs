namespace EmployeeManagementSystem
{
    public abstract class Employee
    {
        private int employeeId;
        private string name;
        protected decimal baseSalary;

        public int EmployeeId
        {
            get { return employeeId; }
            protected set { employeeId = value; }
        }

        public string Name
        {
            get { return name; }
            protected set { name = value; }
        }

        protected Employee(int employeeId, string name, decimal baseSalary)
        {
            EmployeeId = employeeId;
            Name = name;
            this.baseSalary = baseSalary;
        }

        public abstract decimal CalculateSalary();

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"ID: {EmployeeId}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Salary: {CalculateSalary()}");
        }
    }
}