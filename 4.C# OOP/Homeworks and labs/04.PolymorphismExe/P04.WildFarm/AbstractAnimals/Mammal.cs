using System;
using System.Collections.Generic;
using System.Text;

namespace P04.WildFarm.AbstractAnimals
{
    public abstract class Mammal : Animal
    {
        public Mammal(string name, double weight, string livingRegion, List<string> canEat, double increase)
            : base(name, weight, canEat, increase)
        {
            LivingRegion = livingRegion;
        }
        public string LivingRegion { get; private set; }
        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
