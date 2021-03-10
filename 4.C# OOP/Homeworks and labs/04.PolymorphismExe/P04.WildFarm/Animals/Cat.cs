using P04.WildFarm.AbstractAnimals;
using P04.WildFarm.Foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace P04.WildFarm.Animals
{
    public class Cat : Feline
    {
        private const double increase = 0.30;
        public Cat(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed, new List<string>() { nameof(Meat), nameof(Vegetable) }, increase)
        {
        }

        public override void Talk()
        {
            Console.WriteLine("Meow");
        }

    }
}
