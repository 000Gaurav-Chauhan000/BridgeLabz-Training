using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAutomationSystem
{
    internal class ApplianceMenu
    {
        IAppliance light = new Light();
        IAppliance fan = new Fan();
        IAppliance ac = new AC();

        public void DisplayMenu()
        {
            Console.WriteLine("Welcome to the Home Automation System");
            Console.WriteLine("1. Turn On Light");
            Console.WriteLine("2. Turn Off Light");
            Console.WriteLine("3. Turn On Fan");
            Console.WriteLine("4. Turn Off Fan");
            Console.WriteLine("5. Turn On AC");
            Console.WriteLine("6. Turn Off AC");
            Console.WriteLine("7. Exit from board");
            Console.WriteLine("Please select an option (1-6): ");
            string choice;
            while (true)
            {
                Console.WriteLine("Please select a valid option (1-7): ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        light.TurnOn();
                        break;
                    case "2":
                        light.TurnOff();
                        break;
                    case "3":
                        fan.TurnOn();
                        break;
                    case "4":
                        fan.TurnOff();
                        break;
                    case "5":
                        ac.TurnOn();
                        break;
                    case "6":
                        ac.TurnOff();
                        break;
                    case "7":
                        Console.WriteLine("You drew away from the electric board");
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
                if (choice == "7")
                {
                    return;
                }
            }
        } 
    }
}
