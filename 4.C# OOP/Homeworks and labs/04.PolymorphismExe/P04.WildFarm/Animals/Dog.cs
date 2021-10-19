using P04.WildFarm.AbstractAnimals;
using P04.WildFarm.Foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace P04.WildFarm.Animals
{
    public class Dog : Mammal
    {
        private const double increase = 0.40;
        public Dog(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion, new List<string>() { nameof(Meat) }, increase)
        {
        }
        public override void Talk()
        {
            Console.WriteLine("Woof!");
        }

    }
}
