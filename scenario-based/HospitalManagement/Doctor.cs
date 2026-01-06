using System;

namespace HospitalManagement
{
    internal class Doctor
    {
        Dictionary<int, Patient> patients = new Dictionary<int, Patient>();

        Patient p = new Patient();
        public void DoctorMenu()
        {
            while (true)
            {
                Console.WriteLine("\npress 1. for Add Patients Details\npress 2. for ShowAll Patient\npress 3. for show Specific Patient \npress 4. for exit ");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1) { AddPatient(); Console.WriteLine("Patient Added Successfully"); }
                else if (choice == 2) ShowAllDisplayInfo();
                else if (choice == 3) ShowSpecificPatient();
                else if (choice == 4) return;
                else Console.WriteLine("Invalid Choice");
            }
        }
        void AddPatient()
        {
            Console.WriteLine("Enter Patient ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Patient Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Patient Diagnosis: ");
            string diagnosis = Console.ReadLine();
            Console.WriteLine("Enter Patient Gender: M or F");
            char gender = Convert.ToChar(Console.ReadLine()[0]);

            patients[id] = new Patient(id, name, diagnosis, gender);

        }
        void ShowAllDisplayInfo(){
            foreach (var patient in patients.Values){
                patient.DisplayInfo();
                Console.WriteLine("-------------------");
            }
        }
        void ShowSpecificPatient(){
            Console.WriteLine("Enter Patient ID to display details: ");
            int id = Convert.ToInt32(Console.ReadLine());
            if (patients.ContainsKey(id))    patients[id].DisplayInfo();

            else    Console.WriteLine("Patient not found.");
        }
    }
}