using System;

namespace BusTracker{
    class BusStop{
        private int totalDistance = 0;

        public void AddStopDistance(int distance){
            totalDistance += distance;
            Console.WriteLine("Distance added: " + distance + " km");
            Console.WriteLine("Total distance covered: " + totalDistance + " km");
        }
        public int GetTotalDistance(){
            return totalDistance;
        }
    }
}
