

namespace HospitalManagement{
    public class RunApplication{
        public static void RunApp(){
            Patient p = new Patient();
            Doctor d = new Doctor();
            while (true)
            {
                Console.WriteLine(" =========== Main Menu =========== \n\n");
                Console.WriteLine("Hospital Management System is running...");
                Console.WriteLine("\npress 1. for logged as Patient");
                Console.WriteLine("press 2. for logged as Doctor\npress 3. for Exit \n");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        p.PatientMenu();
                        break;
                    case 2:
                        d.DoctorMenu();
                        break;
                    case 3:
                        Console.WriteLine("Exiting application. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Exiting application.");
                        break;
                }
            }
        }
    }
}
