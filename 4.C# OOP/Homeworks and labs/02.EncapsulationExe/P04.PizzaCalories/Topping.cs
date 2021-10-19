using System;
using System.Collections.Generic;
using System.Text;

namespace P04.PizzaCalories
{
    public class Topping
    {
        private string toppingType;
        private double weight;
        

        public Topping(string topping, double weight)
        {
            ToppingType = topping;
            Weight = weight;
        }
        public string ToppingType
        {
            get => toppingType;
            private set
            {
                var type = value.ToLower();
                if (type == "meat" || type == "veggies" || type == "cheese" || type == "sauce")
                {
                    toppingType = value;
                }
                else
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
            }
        }
        public double Weight
        {
            get => weight;
            private set
            {
                if (value >= 1 && value <= 50)
                {
                    weight = value;
                }
                else
                {
                    throw new ArgumentException($"{ToppingType} weight should be in the range [1..50].");
                }
            }
        }
        public double Calories => GetCalories();

        private double GetCalories()
        {
            var type = GetModifiers(toppingType);
            return 2 * weight * type;
        }

        private double GetModifiers(string toppingType)
        {
            var type = toppingType.ToLower();
            if (type == "meat")
            {
                return 1.2;
            }
            if (type == "cheese")
            {
                return 1.1;
            }
            if (type == "veggies")
            {
                return 0.8;
            }
            return 0.9;
        }
    }
}
