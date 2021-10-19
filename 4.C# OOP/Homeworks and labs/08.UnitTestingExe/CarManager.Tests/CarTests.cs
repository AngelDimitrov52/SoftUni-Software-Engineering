using CarManager;
using NUnit.Framework;
using System;

namespace Tests
{
    public class CarTests
    {
        private Car car;
        [SetUp]
        public void Setup()
        {
            car = new Car("Opel", "Astra", 2.5, 30);
        }

        [Test]
        public void Ctor_Base_ShouldSetFuelAmountToZero()
        {
            Car car = new Car("Opel", "Astra", 2.5, 30);

            Assert.That(car.FuelAmount, Is.EqualTo(0));
        }

        [Test]
        [TestCase("", "Astra", 2.5, 30)]
        [TestCase(null, "Astra", 2.5, 30)]
        [TestCase("Opel", null, 2.5, 30)]
        [TestCase("Opel", "", 2.5, 30)]
        [TestCase("Opel", "Astra", 0, 30)]
        [TestCase("Opel", "Astra", -23, 30)]
        [TestCase("Opel", "Astra", 2.5, 0)]
        [TestCase("Opel", "Astra", 2.5, -31)]
        public void Ctor_WhenSetInvalidFields_ShoudThrow
            (string make, string model, double fuelConsumption, double fuelCapacity)
        {
            Assert.Throws<ArgumentException>(() => car = new Car(make, model, fuelConsumption, fuelCapacity));
        }

        [Test]
        [TestCase("Opel", "Astra", 2.5, 30)]
        public void Ctor_WhenSetValidFields_ShoudSetCorrectly
            (string make, string model, double fuelConsumption, double fuelCapacity)
        {
            car = new Car(make, model, fuelConsumption, fuelCapacity);
            Assert.AreEqual(car.Make, make);
            Assert.AreEqual(car.Model, model);
            Assert.AreEqual(car.FuelConsumption, fuelConsumption);
            Assert.AreEqual(car.FuelCapacity, fuelCapacity);
        }

        [Test]
        public void Drive_ShouldThrow_When_FuelNeededIsMoreThanFuelAmound()
        {
            Assert.Throws<InvalidOperationException>(() => car.Drive(100000));
        }
        [Test]
        public void Drive_ShouldRemuveFromFuelAmount_FuelNeeded()
        {
            car = new Car("Opel", "Astra", 2.5, 330);
            car.Refuel(200);
            double distance = 1.1;
            double fuelNeeded = (distance / 100) * car.FuelConsumption;
            double fuelAmount = car.FuelAmount - fuelNeeded;
            car.Drive(distance);

            Assert.AreEqual(car.FuelAmount, fuelAmount);
        }
        [Test]
        [TestCase(0)]
        [TestCase(-12)]
        public void Refuel_WhenFuelToRefuelIsZeroOrNegative_ShouldThrow(double fuelToRefuel)
        {
            Assert.Throws<ArgumentException>(() => car.Refuel(fuelToRefuel));
        }
        [Test]
        public void Refuel_WhenFuelToRefuelOk_ShouldRefuel()
        {
            double amount = car.FuelAmount;
            car.Refuel(23);
            Assert.AreEqual(car.FuelAmount, amount + 23);
        }
        [Test]
        public void Refuel_WhenFuelIsMoreThanCapacity_ShouldAmountByEqualToCapacity()
        {
           
            car.Refuel(500);
            Assert.AreEqual(car.FuelAmount, car.FuelCapacity);
        }


    }
}