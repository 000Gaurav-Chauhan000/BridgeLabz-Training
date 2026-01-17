using System;

namespace TrafficManager
{
    internal class TrafficMenu
    {
        public static void ShowMenu(Roundabout roundabout, VehicleQueue queue)
        {
            int choice;
            do
            {
                Console.WriteLine("\n=== Traffic Manager ===");
                Console.WriteLine("1. Vehicle arrives (Queue)");
                Console.WriteLine("2. Allow vehicle into roundabout");
                Console.WriteLine("3. Vehicle exits roundabout");
                Console.WriteLine("4. Display roundabout");
                Console.WriteLine("5. Exit");
                Console.Write("Choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter vehicle number: ");
                        queue.Enqueue(Console.ReadLine());
                        break;

                    case 2:
                        string vehicle = queue.Dequeue();
                        if (vehicle != null)
                            roundabout.AddVehicle(vehicle);
                        break;

                    case 3:
                        roundabout.RemoveVehicle();
                        break;

                    case 4:
                        roundabout.Display();
                        break;
                }

            } while (choice != 5);
        }
    }
}
