using P04.WildFarm.AbstractAnimals;
using P04.WildFarm.Foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace P04.WildFarm.Animals
{
    public class Hen : Bird
    {
        private const double increase = 0.35;
        public Hen(string name, double weight, double wingSize)
            : base(name, weight, wingSize,
                  new List<string>() { nameof(Fruit), nameof(Meat), nameof(Seeds), nameof(Vegetable) }, increase)
        {
        }
        public override void Talk()
        {
            Console.WriteLine("Cluck");
        }

    }
}
