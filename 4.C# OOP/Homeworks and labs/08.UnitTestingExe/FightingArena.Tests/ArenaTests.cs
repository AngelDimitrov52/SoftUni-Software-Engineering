
using FightingArena;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{
    public class ArenaTests
    {
        private Arena arena;
        [SetUp]
        public void Setup()
        {
            arena = new Arena();
        }
        [Test]
        public void Ctor_ShouldSetNotNull()
        {
            Assert.That(arena, Is.Not.Null);
        }
        [Test]
        public void Counter_ShouldSetZero_WhenIsEmpty()
        {
       
            Assert.AreEqual(arena.Count, 0);
        }

        [Test]
        public void Counter_ShouldSetCorret()
        {
            arena.Enroll(new Warrior("angel", 100, 100));
            Assert.AreEqual(arena.Count, 1);
        }
        [Test]
        public void WarriorsProp_ReturnAllWarriors()
        {
            arena.Enroll(new Warrior("angel", 100, 100));
            arena.Enroll(new Warrior("Angel", 100, 100));

            IReadOnlyCollection<Warrior> list = arena.Warriors;

            Assert.That(list, Is.EquivalentTo(arena.Warriors));

        }
        [Test]
        public void Enroll_Throw_WhenAddTwoEqualsWarriors()
        {
            arena.Enroll(new Warrior("angel", 100, 100));
            Assert.Throws<InvalidOperationException>(() => arena.Enroll(new Warrior("angel", 50, 100)));
        }
        [Test]
        [TestCase("Angel", "Boqn")]
        [TestCase("Boqn", "Angel")]
        [TestCase("Boqn", "Boqn")]

        public void Fight_ThrowEx_WhenNullNames(string firstWarrior, string secondWarrior)
        {
            arena = new Arena();
            arena.Enroll(new Warrior("Angel", 100, 100));
            arena.Enroll(new Warrior("Dany", 100, 100));

            Assert.Throws<InvalidOperationException>(() => arena.Fight(firstWarrior, secondWarrior));
        }
        [Test]

        public void Fight_Should_FightTwoWarriors()
        {
            Warrior warrior1 = new Warrior("Angel", 100, 110);
            Warrior warrior2 = new Warrior("Dany", 100, 110);

            arena = new Arena();
            arena.Enroll(warrior1);
            arena.Enroll(warrior2);

            arena.Fight("Angel","Dany");
            Assert.AreEqual(warrior1.HP, 10);
            Assert.AreEqual(warrior2.HP, 10);
            
        }
        [Test]
        public void When_Enroll_ShouldAddWorrior()
        {
            string name = "Angel";

            arena.Enroll(new Warrior("Angel", 100, 110));
            Assert.IsTrue(arena.Warriors.Any(p => p.Name == name));
        }
    }
}
