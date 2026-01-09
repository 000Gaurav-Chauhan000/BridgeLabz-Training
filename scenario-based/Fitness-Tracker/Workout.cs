using System;
using System.Collections.Generic;
using System.Text;

namespace Fitness_Tracker{
    internal abstract class Workout : ITrackable {
        public int duration { get; set; }

        public Workout(int duration){

            this.duration = duration;
        }
        public abstract void Track();
        public override string ToString(){
            return $"Workout Duration : {duration} minutes";
        }

    }
}