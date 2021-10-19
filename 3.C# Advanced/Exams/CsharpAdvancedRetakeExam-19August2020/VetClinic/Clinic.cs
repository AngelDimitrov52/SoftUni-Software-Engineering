using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VetClinic
{
    public class Clinic
    {
        private List<Pet> data;
        private int capacity;

        public Clinic(int capacity)
        {
            data = new List<Pet>(capacity);
            this.capacity = capacity;
            Capacity = capacity;
        }
        public int Capacity
        {
            get;
        }

        public int Count
        {
            get => data.Count;
        }

        public void Add(Pet pet)
        {
            if (data.Count < capacity)
            {
                data.Add(pet);
            }
        }
        public bool Remove(string name)
        {
            foreach (var item in data)
            {
                if (item.Name == name)
                {
                    data.Remove(item);
                    return true;
                }
            }
            return false;
        }
        public Pet GetPet(string name, string owner)
        {
            foreach (var item in data)
            {
                if (item.Name == name && item.Owner == owner)
                {
                    return item;
                }
            }
            return null;
        }
        public Pet GetOldestPet()
        {
            Pet oldesPet = data.OrderByDescending(n => n.Age).FirstOrDefault();
            return oldesPet;
        }
        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("The clinic has the following patients:");
            foreach (var item in data)
            {
                sb.AppendLine($"Pet {item.Name} with owner: {item.Owner}");
            }
            return sb.ToString();
        }
    }
}
