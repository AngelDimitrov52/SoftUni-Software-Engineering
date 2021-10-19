using P04.WildFarm.Foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace P04.WildFarm.AbstractAnimals
{
    public abstract class Animal
    {
        private List<string> canEat;
        private double increase;
        protected Animal(string name, double weight, List<string> canEat, double increase)
        {
            Name = name;
            Weight = weight;
            this.canEat = canEat;
            this.increase = increase;
        }

        public string Name { get; private set; }
        public double Weight { get; set; }
        public int FoodEaten { get; private set; }

        public virtual void Talk()
        {

        }

        public void EatFood(Food food)
        {
            string type = food.GetType().Name;
            int quantityFood = food.Quantity;

            if (!canEat.Contains(type))
            {
                throw new ArgumentException($"{GetType().Name} does not eat {type}!");
            }
            Weight += quantityFood * increase;
            FoodEaten += quantityFood;
        }

    }
}
