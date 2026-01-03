using System;

class Patient{
    public static string HospitalName = "Harmony Hospital";
    private static int totalPatients = 0;

    public string Name;
    public int Age;
    public string Ailment;
    public readonly int PatientID;

    public Patient(int PatientID, string Name, int Age, string Ailment){
        this.PatientID = PatientID;
        this.Name = Name;
        this.Age = Age;
        this.Ailment = Ailment;
        totalPatients++;
    }

    public static void GetTotalPatients(){
        Console.WriteLine(totalPatients);
    }

    public void DisplayPatient(object obj){
        if (obj is Patient){
            Console.WriteLine(HospitalName);
            Console.WriteLine(PatientID);
            Console.WriteLine(Name);
            Console.WriteLine(Age);
            Console.WriteLine(Ailment);
        }
    }

    static void Main(){
        Patient p1 = new Patient(301, "Li Hua", 30, "Fever");
        Patient p2 = new Patient(302, "Wang Fang", 45, "Arthritis");

        p1.DisplayPatient(p1);
        p2.DisplayPatient(p2);

        Patient.GetTotalPatients();
    }
}
