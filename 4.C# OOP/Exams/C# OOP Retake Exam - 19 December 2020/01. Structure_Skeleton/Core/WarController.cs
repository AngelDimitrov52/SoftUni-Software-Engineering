using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WarCroft.Constants;
using WarCroft.Entities.Characters;
using WarCroft.Entities.Characters.Contracts;
using WarCroft.Entities.Items;

namespace WarCroft.Core
{
    public class WarController
    {
        private List<Character> charactersParty;
        private Stack<Item> itemsPool;
        public WarController()
        {
            charactersParty = new List<Character>();
            itemsPool = new Stack<Item>();
        }

        public string JoinParty(string[] args)
        {
            string type = args[0];
            string name = args[1];
            Character character = null;

            if (type == nameof(Priest))
            {
                character = new Priest(name);
            }
            else if (type == nameof(Warrior))
            {
                character = new Warrior(name);
            }

            if (character == null)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.InvalidCharacterType, type));
            }
            charactersParty.Add(character);

            return string.Format(SuccessMessages.JoinParty, name);

        }

        public string AddItemToPool(string[] args)
        {
            string name = args[0];
            Item item = null;

            if (name == nameof(FirePotion))
            {
                item = new FirePotion();
            }
            else if (name == nameof(HealthPotion))
            {
                item = new HealthPotion();
            }
            if (item == null)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.InvalidItem, name));
            }

            itemsPool.Push(item);

            return string.Format(SuccessMessages.AddItemToPool, name);
        }

        public string PickUpItem(string[] args)
        {
            string name = args[0];
            Character character = charactersParty.FirstOrDefault(p => p.Name == name);

            if (character == null)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.CharacterNotInParty, name));
            }

            if (itemsPool.Count == 0)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.ItemPoolEmpty));
            }
            Item item = itemsPool.Pop();
            character.Bag.AddItem(item);

            return string.Format(SuccessMessages.PickUpItem, name, item.GetType().Name);
        }

        public string UseItem(string[] args)
        {
            string charName = args[0];
            string itemName = args[1];

            Character character = charactersParty.FirstOrDefault(p => p.Name == charName);
            if (character == null)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.CharacterNotInParty, charName));
            }

            Item item = character.Bag.GetItem(itemName);

            character.UseItem(item);

            return string.Format(SuccessMessages.UsedItem, charName, itemName);

        }

        public string GetStats()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var character in charactersParty.OrderByDescending(p => p.IsAlive).ThenByDescending(p => p.Health))
            {
                sb.AppendLine($"{character.Name} - HP: {character.Health}/{character.BaseHealth}," +
                    $" AP: {character.Armor}/{character.BaseArmor}, Status: {character}");
            }

            return sb.ToString().TrimEnd();
        }

        public string Attack(string[] args)
        {
            string attackerName = args[0];
            string receiverName = args[1];

            Character attacker = charactersParty.FirstOrDefault(p => p.Name == attackerName);
            Character receiver = charactersParty.FirstOrDefault(p => p.Name == receiverName);

            if (attacker == null)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.CharacterNotInParty, attackerName));
            }

            if (receiver == null)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.CharacterNotInParty, receiverName));
            }

            if (attacker.GetType().Name == nameof(Priest))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.AttackFail, attackerName));
            }

            IAttacker attackerToAttac = (IAttacker)attacker;
            attackerToAttac.Attack(receiver);


            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{attackerName} attacks {receiverName} for {attacker.AbilityPoints} hit points!" +
                $" {receiverName} has {receiver.Health}/{receiver.BaseHealth} HP and {receiver.Armor}/{receiver.BaseArmor} AP left!");

            if (receiver.IsAlive == false)
            {
                sb.AppendLine($"{receiver.Name} is dead!");
            }

            return sb.ToString().TrimEnd();

        }

        public string Heal(string[] args)
        {
            string healerName = args[0];
            string receiverName = args[1];

            Character healer = charactersParty.FirstOrDefault(p => p.Name == healerName);
            Character receiver = charactersParty.FirstOrDefault(p => p.Name == receiverName);

            if (healer == null)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.CharacterNotInParty, healerName));
            }

            if (receiver == null)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.CharacterNotInParty, receiverName));
            }

            if (healer.GetType().Name == nameof(Warrior))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.AttackFail, healerName));
            }

            IHealer healerToHeal = (IHealer)healer;
            healerToHeal.Heal(receiver);


            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{healer.Name} heals {receiver.Name} for {healer.AbilityPoints}!" +
                $" {receiver.Name} has {receiver.Health} health now!");

            return sb.ToString().TrimEnd();
        }
    }
}
