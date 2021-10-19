using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Computers.Tests
{
    public class Tests
    {
        private ComputerManager computersManager;
        [SetUp]
        public void Setup()
        {
            this.computersManager = new ComputerManager();
        }

        [Test]
        public void Ctor_Working()
        {
            Computer computer = new Computer("Asus", "RX-200", 1000);

            Assert.AreEqual("Asus", computer.Manufacturer);
            Assert.AreEqual("RX-200", computer.Model);
            Assert.AreEqual(1000, computer.Price);
            Assert.IsNotNull(computer);
        }

        [Test]
        public void ComputersCount_IfNotEmpty()
        {
            Computer computer = new Computer("Asus", "RX-200", 1000);

            computersManager.AddComputer(computer);

            Assert.That(computersManager.Count, Is.EqualTo(1));
        }
        [Test]
        public void ComputersCount_WorkingRight()
        {
            Assert.That(computersManager.Count, Is.Zero);
        }

        [Test]
        public void ComputerIfAllreadyExist_ThrowsExeption()
        {
            Computer computer = new Computer("Asus", "RX-200", 1000);

            computersManager.AddComputer(computer);

            Assert.Throws<ArgumentException>(() => computersManager.AddComputer(computer));
        }
        [Test]
        public void ValidateNullValue_Message()
        {
            Assert.Throws<ArgumentNullException>(() => computersManager.AddComputer(null));
        }
        [Test]
        public void RemoveComputers_Test()
        {
            Computer computer = new Computer("Asus", "RX-200", 1000);

            computersManager.AddComputer(computer);
            Assert.That(computersManager.RemoveComputer("Asus", "RX-200"), Is.EqualTo(computer));
        }
        [Test]
        public void RemoveComputers_ThrowsException()
        {
            Computer computer = new Computer("Asus", "RX-200", 1000);

            computersManager.AddComputer(computer);
            Assert.Throws<ArgumentException>(() => computersManager.RemoveComputer("Assssus", "RX-200"));
        }
        [Test]
        public void RemoveComputers_ReturnsCount()
        {
            Computer computer = new Computer("Asus", "RX-200", 1000);

            computersManager.AddComputer(computer);
            computersManager.RemoveComputer("Asus", "RX-200");
            Assert.AreEqual(0, computersManager.Count);
        }
        [Test]
        public void GetComp_IsNull()
        {
            Assert.Throws<ArgumentException>(() => computersManager.GetComputer("HP", "hp"));
        }

        [Test]
        public void GetComp_ReturnValue()
        {
            Computer computer = new Computer("Asus", "ROG", 1000);
            computersManager.AddComputer(computer);

            Assert.That(computersManager.GetComputer("Asus", "ROG"), Is.EqualTo(computer));
        }
        [Test]
        public void GetComp_ByManufacturer()
        {
            Computer computer = new Computer("Asus", "Rog", 1000);
            computersManager.AddComputer(computer);

            var result = computersManager.GetComputersByManufacturer("Asus");

            Assert.That(result.Count, Is.EqualTo(1));
            Assert.AreEqual(result, computersManager.Computers);
        }

        [Test]
        public void GetComp_IReadOnly()
        {
            Computer computer1 = new Computer("Asus", "Rog", 1000);
            Computer computer2 = new Computer("Lenovo", "P-100", 1000);

            computersManager.AddComputer(computer1);
            computersManager.AddComputer(computer2);

            var comps = computersManager.Computers;
            Assert.That(comps.Count, Is.EqualTo(computersManager.Count));
        }
        [Test]
        public void GetComp_ThrowsExp()
        {
            Computer computer = new Computer("Asus", "Rog", 1000);
            computersManager.AddComputer(computer);

            Assert.Throws<ArgumentNullException>(() => computersManager.GetComputer("Asus", null));
        }
        [Test]
        public void GetComp_ThrowsExpWithManufacturerNull()
        {
            Computer computer = new Computer("Asus", "Rog", 1000);
            computersManager.AddComputer(computer);

            Assert.Throws<ArgumentNullException>(() => computersManager.GetComputer(null, "Rog"));
        }
        [Test]
        public void GetByManufacturer_ThrowsExeption()
        {
            Assert.Throws<ArgumentNullException>(() => computersManager.GetComputersByManufacturer(null));
        }
        [Test]
        public void GetAllByManufacturerShouldReturnCorrectCollection()
        {
            Computer computer = new Computer("Asus", "Rog", 1000);

            computersManager.AddComputer(computer);
            computersManager.AddComputer(new Computer("Asus", "Rx-200", 899.99m));
            computersManager.AddComputer(new Computer("Lenovo", "P-200", 420));
            var collection = computersManager.GetComputersByManufacturer("Asus");

            Assert.That(collection.Count, Is.EqualTo(2));

        }
    }
}