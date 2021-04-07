using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WarCroft.Constants;
using WarCroft.Entities.Items;

namespace WarCroft.Entities.Inventory.Contracts
{
    public abstract class Bag : IBag
    {

        private readonly List<Item> items;
        public Bag(int capacity)
        {
            Capacity = capacity;
            items = new List<Item>();
        }
        public int Capacity { get; set; } = 100;


        public int Load => items.Sum(p => p.Weight);

        public IReadOnlyCollection<Item> Items => items;

        public void AddItem(Item item)
        {
            if (Load + item.Weight > Capacity)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.ExceedMaximumBagCapacity));
            }

            items.Add(item);
        }

        public Item GetItem(string name)
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.EmptyBag));
            }
            Item item = items.FirstOrDefault(p => p.GetType().Name == name);

            if (item == null)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.ItemNotFoundInBag, name));
            }

            items.Remove(item);
            return item;

        }
    }
}
