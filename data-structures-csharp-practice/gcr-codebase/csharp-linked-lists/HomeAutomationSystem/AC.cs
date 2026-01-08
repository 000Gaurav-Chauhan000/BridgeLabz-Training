using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAutomationSystem
{
    internal class AC : IAppliance
    {
        public void TurnOff()
        {
            Console.WriteLine("AC turned off");
        }
        public void TurnOn()
        {
            Console.WriteLine("Beep - Peep");
        }
    }
}
