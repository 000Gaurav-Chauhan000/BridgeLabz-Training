using System;
using System.Collections.Generic;
using System.Text;

namespace BirdSanctuary
{
    internal class Sparrow : Bird, IFlyable
    {
        public Sparrow(string name, string color, string species) : base(name, color, species) { }
        public void CanFly()
        {
            Console.WriteLine($"{name} the {species} can fly.");
        }
    }
}
