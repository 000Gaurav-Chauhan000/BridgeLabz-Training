namespace EmployeeManagementSystem
{
    class Program
    {
        static void Main()
        {
            List<Employee> employees = new List<Employee>();

            FullTimeEmployee emp1 = new FullTimeEmployee(11, "Kuang Maô", 50000);
            emp1.AssignDepartment("HR");

            PartTimeEmployee emp2 = new PartTimeEmployee(12, "Nia Zhang", 500, 80);
            emp2.AssignDepartment("IT");

            employees.Add(emp1);
            employees.Add(emp2);

            foreach (Employee emp in employees)
            {
                emp.DisplayDetails();
                Console.WriteLine("\n-----------------------\n");
            }
        }
    }
}