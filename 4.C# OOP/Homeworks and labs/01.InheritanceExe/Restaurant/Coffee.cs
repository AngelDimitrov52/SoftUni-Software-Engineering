using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Coffee : HotBeverage
    {
        private const decimal price = 3.50M;
        private const double milli = 50; 
        public Coffee(string name) 
            : base(name, price, milli)
        {

        }
        public double Coffeine { get; set; }
    }
}
