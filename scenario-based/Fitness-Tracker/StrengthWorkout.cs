using System;
using System.Collections.Generic;
using System.Text;

namespace Fitness_Tracker
{
    internal class StrengthWorkout : Workout
    {
        public StrengthWorkout(int duration) : base(duration) { }

        public override void Track(){
            Console.WriteLine("Starting Strength Workout for " + duration + " minutes.");
        }

        public override string ToString()
        {     return base.ToString() + " (Strength Workout)"; }   
    }
}
