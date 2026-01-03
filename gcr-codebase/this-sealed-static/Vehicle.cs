using System;

class Vehicle
{
    public static double RegistrationFee = 5000;

    public string OwnerName;
    public string VehicleType;
    public readonly string RegistrationNumber;

    public Vehicle(string OwnerName, string VehicleType, string RegistrationNumber){
        this.OwnerName = OwnerName;
        this.VehicleType = VehicleType;
        this.RegistrationNumber = RegistrationNumber;
    }

    public static void UpdateRegistrationFee(double newFee){
        RegistrationFee = newFee;
    }

    public void DisplayVehicle(object obj){
        if (obj is Vehicle){
            Console.WriteLine(OwnerName);
            Console.WriteLine(VehicleType);
            Console.WriteLine(RegistrationNumber);
            Console.WriteLine(RegistrationFee);
        }
    }

    static void Main(){
        Vehicle v1 = new Vehicle("Li Wei", "Car", "C1001");
        Vehicle v2 = new Vehicle("Zhang Min", "Bike", "N-002");

        Vehicle.UpdateRegistrationFee(6500);

        v1.DisplayVehicle(v1);
        v2.DisplayVehicle(v2);
    }
}
