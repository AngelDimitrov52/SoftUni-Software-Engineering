using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var tires = new Tire[4]
            {
               new Tire(2017 ,2.20),
               new Tire(1 , 1.30),
               new Tire(1 , 2.25),
               new Tire(1 , 8.25)
            };
            Engine engine = new Engine(560, 6300);

            Car car = new Car("VW", "Polo", 2001, 5, 80, engine, tires);
        }
    }
}
