using System;

namespace TrafficManager
{
    internal class Roundabout
    {
        private VehicleNode tail;

        public void AddVehicle(string number)
        {
            VehicleNode node = new VehicleNode(number);

            if (tail == null)
            {
                tail = node;
                tail.Next = tail;
            }
            else
            {
                node.Next = tail.Next;
                tail.Next = node;
                tail = node;
            }

            Console.WriteLine($"Vehicle {number} entered.");
        }

        public void RemoveVehicle()
        {
            if (tail == null)
            {
                Console.WriteLine("Roundabout empty.");
                return;
            }

            VehicleNode head = tail.Next;

            if (head == tail)
                tail = null;
            else
                tail.Next = head.Next;

            Console.WriteLine($"Vehicle {head.VehicleNo} exited.");
        }

        public void Display()
        {
            if (tail == null)
            {
                Console.WriteLine("Roundabout empty.");
                return;
            }

            VehicleNode temp = tail.Next;
            Console.Write("Roundabout: ");

            do
            {
                Console.Write(temp.VehicleNo + " -> ");
                temp = temp.Next;
            } while (temp != tail.Next);

            Console.WriteLine("(loop)");
        }
    }
}