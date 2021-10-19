using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guild
{
    public class Guild
    {
        private readonly List<Player> roster;
        public Guild(string name, int capacity)
        {
            roster = new List<Player>(capacity);
            Name = name;
            Capacity = capacity;
        }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count { get => roster.Count; }

        public void AddPlayer(Player player)
        {
            if (roster.Count < Capacity)
            {
                roster.Add(player);
            }
        }
        public bool RemovePlayer(string name)
        {
            foreach (var item in roster)
            {
                if (item.Name == name)
                {
                    roster.Remove(item);
                    return true;
                }
            }
            return false;
        }
        public void PromotePlayer(string name)
        {
            foreach (var item in roster)
            {
                if (item.Name == name)
                {
                    item.Rank = "Member";
                    break;
                }
            }

        }
        public void DemotePlayer(string name)
        {
            foreach (var item in roster)
            {
                if (item.Name == name)
                {
                    item.Rank = "Trial";
                    break;
                }
            }
        }
        public Player[] KickPlayersByClass(string classString)
        {
            Player[] arr = roster.Where(n => n.Class == classString).ToArray();
            roster.RemoveAll(n => n.Class == classString);
            return arr;
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Players in the guild: {Name}");
            foreach (var item in roster)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString().Trim();
        }
    }
}
