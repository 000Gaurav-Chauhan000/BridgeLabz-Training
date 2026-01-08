using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAutomationSystem
{
    internal class Light : IAppliance
    {
        public void TurnOff()
        {
            Console.WriteLine("Light turned off");
        }
        public void TurnOn()
        {
            Console.WriteLine(" (The room has been brightened) ");
        }
    }
}
