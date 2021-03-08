using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public abstract class Animal
    {
        private string name;
        private string favouriteFood;

        public Animal(string name, string food)
        {
            Name = name;
            FavouriteFood = food;
        }

        public string Name
        {
            get => this.name;
            set
            {
                name = value;
            }
        }
        public string FavouriteFood
        {
            get => this.favouriteFood;
            set
            {
                favouriteFood = value;
            }
        }
        public virtual string ExplainSelf()
        {
            return $"I am {Name} and my fovourite food is {FavouriteFood}";
        }

    }
}
