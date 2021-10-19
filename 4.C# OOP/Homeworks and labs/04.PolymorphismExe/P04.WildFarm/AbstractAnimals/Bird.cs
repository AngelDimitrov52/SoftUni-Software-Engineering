using System;
using System.Collections.Generic;
using System.Text;

namespace P04.WildFarm.AbstractAnimals
{
    public abstract class Bird : Animal
    {
        protected Bird(string name, double weight, double wingSize, List<string> canEat, double increase)
            : base(name, weight, canEat, increase)
        {
            WingSize = wingSize;
        }
        public double WingSize { get; private set; }

        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, {WingSize}, {Weight}, {FoodEaten}]";
        }
    }
}
