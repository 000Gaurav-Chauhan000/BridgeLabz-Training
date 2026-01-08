using System;
using System.Reflection;
using System.Xml.Linq;

namespace HospitalManagement{
    internal class Patient
    {
        int id;
        string name;
        string diagnosis;
        char gender;
        int age;
        public Patient(){}
        public Patient(int id,string name,string diagnosis,char gender)
        {
            this.id = id;
            this.name = name;
            this.diagnosis = diagnosis;
            this.gender = gender;
        }
        public void PatientMenu()
        {
            while (true)
            {
                Console.WriteLine("\npress 1. for show Details\npress 2. for Switch for Doctor\npress 3. for exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                if(choice== 1) DisplayInfo();
                else if (choice == 2) return;
                else if (choice == 3) return;
                else Console.WriteLine("Invalid Choice");

            }
        }

        public void DisplayInfo() {
            Console.WriteLine($"Patient ID: {this.id} ");
            Console.WriteLine($"Name: {this.name} ");
            Console.WriteLine($"Diagnosis: {this.diagnosis} ");
            Console.WriteLine($"Gender : {this.gender} ");
        }
    }
}
