using System;
using System.Collections.Generic;
using System.Text;

namespace BirdSanctuary
{
    internal class Penguin : Bird, ISwimmable
    {
        public Penguin(string name, string color, string species) : base(name, color, species) { }
        public void CanSwim()
        {
            Console.WriteLine($"{name} the {species} can swim.");
        }
    }
}
