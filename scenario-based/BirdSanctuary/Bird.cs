using System;
using System.Collections.Generic;
using System.Text;

namespace BirdSanctuary
{
    internal class Bird{
        protected String name;
        protected String color;
        protected String species;

        public Bird(String name, String color, String species){
            this.name = name;
            this.color = color;
            this.species = species;
        }
        public string ToString(){
            return $" Name: {name}, Color: {color}, Species: {species}";
        }
    }
    
}
