using Fitness_Tracker.Fitness_Tracker;
using System;
using System.Collections.Generic;

namespace Fitness_Tracker
{
    class Program
    {
        static void Main()
        {
            WorkoutMenu workoutMenu = new WorkoutMenu();
            workoutMenu.DisplayMenu();

            //UserProfile user = new UserProfile("Pehelwaan");

            //Workout cardio = new CardioWorkout(30);
            //Workout strength = new StrengthWorkout(45);

            //user.AddWorkout(cardio);
            //user.AddWorkout(strength);

            //user.ShowWorkouts();
        }
    }
}