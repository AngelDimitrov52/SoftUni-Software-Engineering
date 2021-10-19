using P04.WildFarm.AbstractAnimals;
using P04.WildFarm.Foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace P04.WildFarm.Animals
{
    public class Mouse : Mammal
    {
        private const double increase = 0.10;
        public Mouse(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion, new List<string>() { nameof(Fruit), nameof(Vegetable) }, increase)
        {
        }
        public override void Talk()
        {
            Console.WriteLine("Squeak");
        }

    }
}
