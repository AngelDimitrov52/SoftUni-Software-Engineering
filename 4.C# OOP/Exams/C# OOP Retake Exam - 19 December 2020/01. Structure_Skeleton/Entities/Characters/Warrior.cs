using System;
using System.Collections.Generic;
using System.Text;
using WarCroft.Constants;
using WarCroft.Entities.Characters.Contracts;
using WarCroft.Entities.Inventory;
using WarCroft.Entities.Inventory.Contracts;

namespace WarCroft.Entities.Characters
{
    public class Warrior : Character, IAttacker
    {
        public Warrior(string name)
            : base(name, 100, 50, 40, new Satchel())
        {
        }

        public void Attack(Character character)
        {
            this.EnsureAlive();

            if (!character.IsAlive)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.AffectedCharacterDead));
            }
            if (this.Name == character.Name && character.GetType().Name == nameof(Warrior))
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.CharacterAttacksSelf));
            }

            character.TakeDamage(AbilityPoints);
        }
    }
}
