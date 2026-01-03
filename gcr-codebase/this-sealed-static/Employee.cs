using System;

class Employee{
    public static string CompanyName = "ABCD";
    private static int totalEmployees = 0;

    public string Name;
    public string Designation;
    public readonly int Id;

    public Employee(string Name, int Id, string Designation){
        this.Name = Name;
        this.Id = Id;
        this.Designation = Designation;
        totalEmployees++;
    }

    public static void DisplayTotalEmployees(){
        Console.WriteLine(totalEmployees);
    }

    public void DisplayDetails(object obj) {
        if (obj is Employee){
            Console.WriteLine(CompanyName);
            Console.WriteLine(Name);
            Console.WriteLine(Id);
            Console.WriteLine(Designation);
        }
    }

    static void Main() { 

        Employee e1 = new Employee("Cu-Chulin", 522, "Developer");

        Employee e2 = new Employee("Xian - Yeow", 102, "Guard");

        e1.DisplayDetails(e1);
        e2.DisplayDetails(e2);
        Employee.DisplayTotalEmployees();
    }
}