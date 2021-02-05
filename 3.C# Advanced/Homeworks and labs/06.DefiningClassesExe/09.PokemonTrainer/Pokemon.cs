using System;
using System.Collections.Generic;
using System.Text;

namespace _09.PokemonTrainer
{
    public class Pokemon
    {
        public Pokemon(string name, string element, int helt)
        {
            Name = name;
            Element = element;
            Health = helt;

        }

        public string Name { get; set; }
        public string Element { get; set; }
        public int Health { get; set; }

       public void ReductHealth()
        {
            this.Health -= 10;
        }
    }
}
