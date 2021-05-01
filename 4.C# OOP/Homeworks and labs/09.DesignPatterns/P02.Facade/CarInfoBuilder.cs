using System;
using System.Collections.Generic;
using System.Text;

namespace P02.Facade
{
    public class CarInfoBuilder : CarBuilderFacade
    {
        public CarInfoBuilder(Car car)
        {
            Car = car;
        }

        public CarInfoBuilder WhitType(string type)
        {
            Car.Type = type;
            return this;
        }
        public CarInfoBuilder WhitColor(string color)
        {
            Car.Color = color;
            return this;
        }
        public CarInfoBuilder WhitNumberOfDoors(int number)
        {
            Car.NumberOfDoors = number;
            return this;
        }
    }
}
