namespace TrafficManager
{
    class Program
    {
        static void Main()
        {
            Roundabout roundabout = new Roundabout();
            VehicleQueue queue = new VehicleQueue();

            TrafficMenu.ShowMenu(roundabout, queue);
        }
    }
}
