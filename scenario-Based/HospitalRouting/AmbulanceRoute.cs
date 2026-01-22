using System;

namespace HospitalRouting
{
    class AmbulanceRoute
    {
        private CircularLinkedList route;

        public AmbulanceRoute(CircularLinkedList list)
        {
            route = list;
        }

        public void RoutePatient()
        {
            UnitNode head = route.GetHead();
            if (head == null) return;

            UnitNode temp = head;

            do
            {
                Console.WriteLine($"Checking {temp.Name}");
                if (temp.IsAvailable)
                {
                    Console.WriteLine($"Patient redirected to {temp.Name}");
                    return;
                }
                temp = temp.Next;
            }
            while (temp != head);

            Console.WriteLine("No available units!");
        }
    }
}