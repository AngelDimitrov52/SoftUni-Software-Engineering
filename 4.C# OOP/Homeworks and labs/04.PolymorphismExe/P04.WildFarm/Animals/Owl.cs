using P04.WildFarm.AbstractAnimals;
using P04.WildFarm.Foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace P04.WildFarm.Animals
{
    public class Owl : Bird
    {
        private const double increase = 0.25;
        public Owl(string name, double weight, double wingSize)
            : base(name, weight, wingSize, new List<string>() { nameof(Meat) }, increase)
        {
        }
        public override void Talk()
        {
            Console.WriteLine("Hoot Hoot");
        }

    }
}
