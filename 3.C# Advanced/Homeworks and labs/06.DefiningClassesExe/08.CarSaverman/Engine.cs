using System;
using System.Collections.Generic;
using System.Text;

namespace _08.CarSaverman
{
    public class Engine
    {
        public Engine()
        {
            Displacement = "n/a";
            Efficiency = "n/a";
        }

        public string Model { get; set; }
        public int Power { get; set; }
        public string Displacement { get; set; }
        public string Efficiency { get; set; }
    }
}
