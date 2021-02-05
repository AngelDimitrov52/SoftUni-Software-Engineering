using System;
using System.Collections.Generic;
using System.Text;

namespace _09.PokemonTrainer
{
    
    public class Trainers
    {
        public Trainers()
        {
            NumberOfBags = 0;
            Pokemons = new List<Pokemon>();
        }
        public string Name{ get; set; }
        public int NumberOfBags { get; set; }
        public List<Pokemon> Pokemons { get; set; }

        
    }
}
