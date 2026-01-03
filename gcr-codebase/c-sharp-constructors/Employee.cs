using System;

class Employee{
    public int employeeID;
    protected string department;
    private double salary;

    public void SetSalary(double amount){
        salary = amount;
    }

    public double GetSalary(){
        return salary;
    }

    static void Main(){
        Employee emp = new Employee();

        emp.employeeID = 5124;
        emp.department = "CSE";
        emp.SetSalary(65000);

        Console.WriteLine(emp.employeeID);
        Console.WriteLine(emp.department);
        Console.WriteLine(emp.GetSalary());
    }
}
