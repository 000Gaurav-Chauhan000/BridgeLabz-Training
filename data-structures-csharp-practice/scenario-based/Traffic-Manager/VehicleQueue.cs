using System;

namespace TrafficManager
{
    internal class VehicleQueue
    {
        private string[] queue = new string[5];
        private int front = 0, rear = -1, count = 0;

        public void Enqueue(string vehicle)
        {
            if (count == queue.Length)
            {
                Console.WriteLine("Queue Overflow.");
                return;
            }

            rear = (rear + 1) % queue.Length;
            queue[rear] = vehicle;
            count++;

            Console.WriteLine($"Vehicle {vehicle} queued.");
        }

        public string Dequeue()
        {
            if (count == 0)
            {
                Console.WriteLine("Queue Underflow.");
                return null;
            }

            string vehicle = queue[front];
            front = (front + 1) % queue.Length;
            count--;

            return vehicle;
        }
    }
}
