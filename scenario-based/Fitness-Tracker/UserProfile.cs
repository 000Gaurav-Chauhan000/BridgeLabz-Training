using System;
using System.Collections.Generic;
using System.Text;

namespace Fitness_Tracker
{
    internal class UserProfile
    {
        public string Name { get; set; }

        private List<ITrackable> workouts = new List<ITrackable>();
            public UserProfile(string name){
            Name = name;
            }

        public void AddWorkout(ITrackable workout) {
            workouts.Add(workout);
        }
        public void ShowWorkouts()
        {
            Console.WriteLine($"\nWorkouts for {Name}:");
            foreach (ITrackable workout in workouts)
            {
                workout.Track();
            }
        }
    }
}