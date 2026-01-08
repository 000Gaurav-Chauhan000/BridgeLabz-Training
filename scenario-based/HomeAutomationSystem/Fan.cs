using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAutomationSystem
{
    internal class Fan : IAppliance
    {
        public void TurnOff()
        {
            Console.WriteLine("Fan turned off");
        }
        public void TurnOn()
        {
            Console.WriteLine("Whoosh - Whoosh");
        }
    }
}
