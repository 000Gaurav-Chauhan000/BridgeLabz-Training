using System;
using System.Collections.Generic;
using System.Text;

namespace BirdSanctuary
{
    sealed class RunApplication
    {
        public void RunApp()
        {
            Bird[] birds =
           {
                new Eagle("Eagle", "Brown", "Eagle"),
                new Sparrow("Sparrow", "Gray", "Sparrow"),
                new Penguin("Penguin", "Black and White", "Penguin"),
                new Seagull("Seagull", "White and Gray", "Seagull")
            };
            foreach (var bird in birds)
            {
                if (bird is IFlyable flyableBird)
                {
                    Console.WriteLine("\n");
                    flyableBird.CanFly();
                }
                if (bird is ISwimmable swimmableBird)
                {
                    Console.WriteLine("\n");
                    swimmableBird.CanSwim();
                }
            }
        }
    }
}