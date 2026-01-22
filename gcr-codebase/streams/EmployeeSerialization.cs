using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public double Salary { get; set; }
}

class EmployeeSerialization
{
    static void Main()
    {
        string filePath = @"C:\Users\gaurav\Desktop\VisualStudioProjects\Collections\employees.json";

        List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Gaurav", Department = "IT", Salary = 60000 },
            new Employee { Id = 2, Name = "Amit", Department = "HR", Salary = 45000 }
        };

        try
        {
            // Serialize
            string jsonData = JsonSerializer.Serialize(employees);
            File.WriteAllText(filePath, jsonData);
            Console.WriteLine("Employees serialized successfully.");

            // Deserialize
            string readData = File.ReadAllText(filePath);
            List<Employee> loadedEmployees =
                JsonSerializer.Deserialize<List<Employee>>(readData);

            Console.WriteLine("\nDeserialized Employee Data:");
            foreach (var emp in loadedEmployees)
            {
                Console.WriteLine($"{emp.Id} | {emp.Name} | {emp.Department} | {emp.Salary}");
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("IO Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
