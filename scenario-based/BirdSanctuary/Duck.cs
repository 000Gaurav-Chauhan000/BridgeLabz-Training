using System;
using System.Collections.Generic;
using System.Text;

namespace BirdSanctuary{
    internal class Duck : Bird, ISwimmable
    {
        public Duck(string name, string color, string species) : base(name, color, species) { 
        }

        public void CanSwim(){
            Console.WriteLine($"{name} the {species} can swim.");
        }
    }

}
