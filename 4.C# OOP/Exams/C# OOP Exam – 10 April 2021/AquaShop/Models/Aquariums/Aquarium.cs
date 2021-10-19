using AquaShop.Models.Aquariums.Contracts;
using AquaShop.Models.Decorations.Contracts;
using AquaShop.Models.Fish.Contracts;
using AquaShop.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AquaShop.Models.Aquariums
{
    public abstract class Aquarium : IAquarium
    {
        private string name;
        private List<IDecoration> decorations;
        private List<IFish> fishs;
        public Aquarium(string name, int capacity)
        {
            decorations = new List<IDecoration>();
            fishs = new List<IFish>();

            Name = name;
            Capacity = capacity;
        }


        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidAquariumName));
                }
                name = value;
            }
        }

        public int Capacity { get; private set; }

        public int Comfort => decorations.Sum(p => p.Comfort);

        public ICollection<IDecoration> Decorations => decorations;

        public ICollection<IFish> Fish => fishs;




        public void AddDecoration(IDecoration decoration)
        {
            decorations.Add(decoration);
        }

        public void AddFish(IFish fish)
        {
            if (fishs.Count == Capacity)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.NotEnoughCapacity));
            }
            fishs.Add(fish);
        }

        public void Feed()
        {
            foreach (var fish in fishs)
            {
                fish.Eat();
            }
        }

        public string GetInfo()
        {


            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Name} ({this.GetType().Name}):");
            if (fishs.Count == 0)
            {
                sb.AppendLine("Fish: none");
            }
            else
            {
                sb.AppendLine($"Fish: {string.Join(", ", fishs)}");
            }
            sb.AppendLine($"Decorations: { decorations.Count}");
            sb.AppendLine($"Comfort: {Comfort}");

            return sb.ToString().TrimEnd();
        }

        public bool RemoveFish(IFish fish)
        {
            if (fishs.Any(p => p.Name == fish.Name))
            {
                fishs.Remove(fish);
                return true;

            }
            else
            {
                return false;
            }

        }

    }
}
