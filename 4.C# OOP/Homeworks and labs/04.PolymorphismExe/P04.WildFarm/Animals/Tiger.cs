using P04.WildFarm.AbstractAnimals;
using P04.WildFarm.Foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace P04.WildFarm.Animals
{
    public class Tiger : Feline
    {
        private const double increase = 1.00;
        public Tiger(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed, new List<string>() { nameof(Meat) }, increase)
        {
        }
        public override void Talk()
        {
            Console.WriteLine("ROAR!!!");
        }

    }
}
