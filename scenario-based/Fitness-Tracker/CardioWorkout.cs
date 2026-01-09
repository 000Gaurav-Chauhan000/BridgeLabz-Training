using System;
using System.Collections.Generic;
using System.Text;

namespace Fitness_Tracker
{
    internal class CardioWorkout : Workout
    {
        public CardioWorkout(int duration) : base(duration) { }
        public override void Track()
        {
            Console.WriteLine("Starting Cardio Workout for " + duration + " minutes.");
        }
        public override string ToString()
        {
            return base.ToString() + " (Cardio Workout)";
        }
    }
}
