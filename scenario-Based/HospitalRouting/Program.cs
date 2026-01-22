namespace HospitalRouting
{
    class Program
    {
        static void Main()
        {
            CircularLinkedList hospitalUnits = new CircularLinkedList();

            hospitalUnits.AddUnit("Emergency", false);
            hospitalUnits.AddUnit("Radiology", false);
            hospitalUnits.AddUnit("Surgery", true);
            hospitalUnits.AddUnit("ICU", false);

            AmbulanceRoute ambulance = new AmbulanceRoute(hospitalUnits);

            ambulance.RoutePatient();

            hospitalUnits.RemoveUnit("Radiology");
            ambulance.RoutePatient();
        }
    }
}
