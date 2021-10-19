using System;
using System.Collections.Generic;
using System.Text;

namespace P04.WildFarm.AbstractAnimals
{
    public abstract class Feline : Mammal
    {
        public Feline(string name, double weight, string livingRegion, string breed, List<string> canEat, double increase)
            : base(name, weight, livingRegion, canEat, increase)
        {
            Breed = breed;
        }
        public string Breed { get; private set; }
        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, {Breed}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
