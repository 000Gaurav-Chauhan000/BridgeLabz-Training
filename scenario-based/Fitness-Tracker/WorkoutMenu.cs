using System;
using System.Collections.Generic;
using System.Text;

namespace Fitness_Tracker
{
    using System;

    namespace Fitness_Tracker
    {
        internal class WorkoutMenu
        {
            public void DisplayMenu()
            {
                Console.Write("Enter name: ");
                string name = Console.ReadLine();

                UserProfile user = new UserProfile(name);

                while (true)
                {
                    Console.WriteLine("\n===== FITTRACK MENU =====");
                    Console.WriteLine("1. Add Cardio Workout");
                    Console.WriteLine("2. Add Strength Workout");
                    Console.WriteLine("3. View Workout History");
                    Console.WriteLine("4. Exit");
                    Console.Write("Enter your choice: ");

                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            AddCardio(user);
                            break;

                        case "2":
                            AddStrength(user);
                            break;

                        case "3":
                            user.ShowWorkouts();
                            break;

                        case "4":
                            Console.WriteLine("Goodbye!");
                            return;

                        default:
                            Console.WriteLine("Invalid choice. Try again.");
                            break;
                    }
                }
            }

            private void AddCardio(UserProfile user)
            {
                Console.Write("Enter duration (minutes): ");
                int duration = int.Parse(Console.ReadLine());

                Workout cardio = new CardioWorkout(duration);
                user.AddWorkout(cardio);

                Console.WriteLine("Cardio workout added successfully.");
            }

            private void AddStrength(UserProfile user)
            {
                Console.Write("Enter duration (minutes): ");
                int duration = int.Parse(Console.ReadLine());

                Workout strength = new StrengthWorkout(duration);
                user.AddWorkout(strength);

                Console.WriteLine("Strength workout added successfully.");
            }
        }
    }

}
