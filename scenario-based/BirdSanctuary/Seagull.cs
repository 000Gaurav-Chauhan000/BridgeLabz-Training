using System;
using System.Collections.Generic;
using System.Text;

namespace BirdSanctuary
{
    internal class Seagull : Bird, IFlyable,ISwimmable
    {
        public Seagull(string name, string color, string species) : base(name, color, species) { }
        public void CanFly()
        {
            Console.WriteLine($"{name} the {species} can fly.");
        }
        public void CanSwim()
        {
            Console.WriteLine($"{name} the {species} can swim.");
        }
    }
}
