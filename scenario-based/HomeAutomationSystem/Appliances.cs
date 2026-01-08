using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAutomationSystem
{
    internal class Appliances
    {
        public string ApplianceName { get; set; }

        public override string ToString() {
            return $"Name :{ApplianceName} ";
        }

    }
}
