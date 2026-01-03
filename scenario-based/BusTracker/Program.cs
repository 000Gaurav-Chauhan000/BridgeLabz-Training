

using System;

namespace BusTracker{
    internal class Program{
        static void Main(){

            BusStop route = new BusStop();
            bool wantsToGetOff = false;

            while (!wantsToGetOff)
            {
                Console.Write("Enter distance for this stop (in km): ");
                int distance = Convert.ToInt32(Console.ReadLine());

                route.AddStopDistance(distance);

                Console.Write("Do you want to get off at this stop? (yes/no): ");
                string choice = Console.ReadLine().ToLower();
                string ans = "yes";

                if (string.Equals(choice, ans, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Passenger wants to get off");
                    break;
                }
            }

            Console.WriteLine("\nPassenger got off.");
            Console.WriteLine("Total distance travelled: " + route.GetTotalDistance() + " km");
        }
    }
}
