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
        private double health;
        private double armor;

        public Character(string name, double health, double armor, double abilityPoints, Bag bag)
        {
            Name = name;
            BaseHealth = health;
            Health = BaseHealth;
            BaseArmor = armor;
            Armor = BaseArmor;
            AbilityPoints = abilityPoints;
            Bag = bag;
        }

        public string Name
        {
            get => name;

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.CharacterNameInvalid));
                }
                name = value;
            }
        }
        public double BaseHealth { get; private set; }

        public double Health
        {
            get => health;
            set
            {

                health = value;
                if (health < 0)
                {
                    health = 0;
                    IsAlive = false;
                }

                if (health > BaseHealth)
                {
                    health = BaseHealth;
                }
            }
        }

        public double BaseArmor { get; private set; }

        public double Armor
        {
            get => armor;
            set
            {
                armor = value;
                if (value >= BaseArmor)
                {
                    armor = BaseArmor;
                }
                if (armor < 0)
                {
                    armor = 0;
                }
            }
        }
        public double AbilityPoints { get; private set; }

        public Bag Bag { get; private set; }

        public bool IsAlive { get; private set; } = true;

        public void TakeDamage(double hitPoints)
        {
            this.EnsureAlive();

            if (Armor == 0)
            {
                Health -= hitPoints;
            }
            else
            {

                Armor -= hitPoints;
                if (Armor < 0)
                {
                    double most = Math.Abs(Armor);
                    Armor = 0;
                    Health -= most;

                }
            }
        }
        public void UseItem(Item item)
        {
            this.EnsureAlive();
            item.AffectCharacter(this);
        }
        protected void EnsureAlive()
        {
            if (!this.IsAlive)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.AffectedCharacterDead));
            }
        }
        public override string ToString()
        {
            if (IsAlive == true)
            {
                return "Alive";
            }
            return "Dead";
        }
    }
}