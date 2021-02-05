using System;
using System.Collections.Generic;
using System.Text;

namespace _08.CarSaverman
{
    public class Car
    {
        public Car()
        {
            Weight = "n/a";
            Color = "n/a";
        }
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public string Weight { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {
            return $"{this.Model}:\n" +
                   $"  {this.Engine.Model}:\n" +
                   $"    Power: {this.Engine.Power}\n" +
                   $"    Displacement: {this.Engine.Displacement}\n" +
                   $"    Efficiency: {this.Engine.Efficiency}\n" +
                   $"  Weight: {this.Weight}\n" +
                   $"  Color: {this.Color}";
        }
    }
}
