using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheRace
{
    public class Race
    {
        private List<Racer> data;

        public Race(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            data = new List<Racer>(capacity);
        }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count { get => data.Count; }

        public void Add(Racer Racer)
        {
            if (data.Count < Capacity)
            {
                data.Add(Racer);
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

        public Racer GetOldestRacer()
        {
            Racer rac = data.OrderByDescending(n => n.Age).FirstOrDefault();
            return rac;
        }
        public Racer GetRacer(string name)
        {
            foreach (var item in data)
            {
                if (item.Name == name)
                {

                    return item;
                }
            }
            return null;
        }
        public Racer GetFastestRacer()
        {
            Racer rac = data.OrderByDescending(n => n.Car.Speed).FirstOrDefault();
            return rac;
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Racers participating at {Name}:");
            foreach (var item in data)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString().Trim();
        }
    }
}
