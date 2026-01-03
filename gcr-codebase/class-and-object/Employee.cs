using System;

internal class Employee{
    int id ; 
    string name;

    double salary;

    public Employee(int id, string name, double salary){
        this.id = id;
        this.name = name;
        this. salary = salary;        
    }

    public void DisplayDetails(){
        Console.WriteLine("The employee details are : "+ id  +" " + name + " "+ salary);
    }
    static void Main(){
        Employee emp = new Employee(123, "Li Huang",50000 );
        Employee emp1 = new Employee(1234, "Guan - Yu", 60000);

        emp.DisplayDetails();
        emp1.DisplayDetails();
    }
}