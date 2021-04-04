using System;

using WarCroft.Constants;
using WarCroft.Entities.Inventory.Contracts;
using WarCroft.Entities.Items;

namespace WarCroft.Entities.Characters.Contracts
{
    public abstract class Character
    {
        // TODO: Implement the rest of the class.
        private string name;
        private double baseHealth;
        private double baseArmor;
        private double health;
        private double armor;

        public Character(string name, double health, double armor, double abilityPoints, Bag bag)
        {
            Name = name;
            baseHealth = health;
            Health = health;
            baseArmor = armor;
            Armor = armor;
            AbilityPoints = abilityPoints;
            Bag = bag;
            IsAlive = true;
        }

        public string Name
        {
            get => name;

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.CharacterNameInvalid);
                }
                name = value;
            }
        }
        public double BaseHealth
        {
            get => baseHealth;

            private set
            {
                baseHealth = value;
            }
        }
        public double Health
        {
            get => health;
            set
            {
                if (value >= BaseHealth)
                {
                    health = BaseHealth;
                }
                health = value;
                if (health < 0)
                {
                    health = 0;
                }
            }
        }

        public double BaseArmor
        {
            get => baseArmor;

            private set
            {
                baseArmor = value;
            }
        }
        public double Armor
        {
            get => armor;
            set
            {
                if (value >= BaseArmor)
                {
                    armor = BaseArmor;
                }
                armor = value;
            }
        }
        public double AbilityPoints { get; private set; }

        public Bag Bag { get; private set; }

        public bool IsAlive { get; set; } = true;

        public void TakeDamage(double hitPoints)
        {
            this.EnsureAlive();

            if (Armor == 0)
            {
                Health -= hitPoints;
            }

            Armor -= hitPoints;
            if (Armor < 0)
            {
                double most = Math.Abs(Armor);
                Armor = 0;

            }

            if (Health <= 0)
            {
                IsAlive = false;
            }

        }
        public void UseItem(Item item)
        {
            item.AffectCharacter(this);
        }
        protected void EnsureAlive()
        {
            if (!this.IsAlive)
            {
                throw new InvalidOperationException(ExceptionMessages.AffectedCharacterDead);
            }
        }
    }
}