using NUnit.Framework;
using System;
using System.Collections.Generic;
using TheRace;

namespace TheRace.Tests
{
    public class RaceEntryTests
    {
        private RaceEntry race;

        [SetUp]
        public void Setup()
        {
            race = new RaceEntry();
        }

        [Test]
        public void Ctor_Test()
        {
            Assert.That(race, Is.Not.Null);
        }

        [Test]
        public void Counter_Test()
        {
            Assert.AreEqual(race.Counter, 0);
        }
        [Test]
        public void AddDriver_WhenDriverIsNull_ThrowEx()
        {
            UnitDriver driver = null;
            Assert.Throws<InvalidOperationException>(() => race.AddDriver(driver));
        }
        [Test]
        public void AddDriver_WhenhaveThisDriver_ThrowEx()
        {
            UnitDriver driverOper = new UnitDriver("Angel", new UnitCar("Opel", 32, 4000));
            UnitDriver driverFord = new UnitDriver("Angel", new UnitCar("Ford", 332, 6000));

            race.AddDriver(driverOper);

            Assert.Throws<InvalidOperationException>(() => race.AddDriver(driverFord));
        }
        [Test]
        public void When_AddDriver_ShouldAddDriverToDictionary()
        {
            UnitDriver driverOper = new UnitDriver("Angel", new UnitCar("Opel", 32, 4000));
            string result = race.AddDriver(driverOper);

            Assert.IsTrue(result == $"Driver {driverOper.Name} added in race.");
            Assert.AreEqual(race.Counter, 1);
        }
        [Test]
        public void When_CalculateAverageHorsePower_ShouldThrowWhenDriverAreLesThanTwo()
        {
            UnitDriver driverOper = new UnitDriver("Angel", new UnitCar("Opel", 32, 4000));
            race.AddDriver(driverOper);

            Assert.Throws<InvalidOperationException>(() => race.CalculateAverageHorsePower());
        }
        [Test]
        public void When_CalculateAverageHorsePower_ShouldWorkWhitValidInput()
        {
            UnitDriver driverOper = new UnitDriver("Angel", new UnitCar("Opel", 100, 4000));
            UnitDriver driverFord = new UnitDriver("Dany", new UnitCar("Ford", 100, 6000));
            UnitDriver driverVW = new UnitDriver("Gogi", new UnitCar("VW", 100, 66000));
            race.AddDriver(driverOper);
            race.AddDriver(driverFord);
            race.AddDriver(driverVW);

            double sum = race.CalculateAverageHorsePower();

            Assert.AreEqual(sum, 100);
        }
    }
}