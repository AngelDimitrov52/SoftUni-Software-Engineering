
using FightingArena;
using NUnit.Framework;
using System;

namespace Tests
{
    public class WarriorTests
    {
        private Warrior warrior;
        [SetUp]
        public void Setup()
        {
            warrior = new Warrior("Angel", 60, 100);
        }

        [Test]
        public void Ctor_SetCorrect()
        {
            string name = "Angel";
            int hp = 49;
            int demage = 40;
            warrior = new Warrior(name, demage, hp);

            Assert.AreEqual(warrior.Damage, demage);
            Assert.AreEqual(warrior.HP, hp);
            Assert.AreEqual(warrior.Name, name);
        }

        [Test]
        [TestCase(" ", 60, 100)]
        [TestCase("", 60, 100)]
        [TestCase(null, 60, 100)]
        [TestCase("Angel", 0, 100)]
        [TestCase("Angel", -60, 100)]
        [TestCase("Angel", 60, -100)]
        public void Ctor_Fail_WhenInvalidNameHPDemage(string name, int demage, int hp)
        {
            Assert.Throws<ArgumentException>(() => warrior = new Warrior(name, demage, hp));
        }

        [Test]
        [TestCase("Angel", 100, 20)]
        [TestCase("Angel", 100, 40)]
        public void Attack_Throw_WhenInvalidWarriorHp(string name, int demage, int hp)
        {
            warrior = new Warrior(name, demage, hp);
            Warrior attackWarior = new Warrior("Gogi", 50, 50);

            Assert.Throws<InvalidOperationException>(() => warrior.Attack(attackWarior));
        }
        [Test]
        
        public void Attack_Throw_WhenInvalidAttackedWarriorHp()
        {
            
            Warrior attackWarior = new Warrior("Gogi", 50, 20);

            Assert.Throws<InvalidOperationException>(() => warrior.Attack(attackWarior));
        }

        [Test]
        public void When_Attack_Should_DecreaseHP()
        {

            Warrior attackWarior = new Warrior("Gogi", 50, 40);
           int hpBefore = warrior.HP;
            warrior.Attack(attackWarior);

           
            Assert.AreEqual(attackWarior.HP,0);
        } 
        [Test]
        public void When_Attack_Should_DecreaseHP2()
        {

            Warrior attackWarior = new Warrior("Gogi", 50, 40);
           int hpBefore = warrior.HP;
            warrior.Attack(attackWarior);

            Assert.AreEqual(warrior.HP, hpBefore - attackWarior.Damage);
            
        }
        [Test]
        public void When_Attack_Should_DecreaseHPAndAttackedWarriorHP()
        {

            Warrior attackWarior = new Warrior("Gogi", 50, 70);
            int attackedWarriorBefore = attackWarior.HP;
            warrior.Attack(attackWarior);

            Assert.AreEqual(attackWarior.HP, attackedWarriorBefore - warrior.Damage);
        }

    }
}