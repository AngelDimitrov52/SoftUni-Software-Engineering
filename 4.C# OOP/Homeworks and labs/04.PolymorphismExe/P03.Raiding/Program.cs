using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.Raiding
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<BaseHero> heros = new List<BaseHero>();

            int n = int.Parse(Console.ReadLine());

            while (heros.Count != n)
            {
                string name = Console.ReadLine();
                string type = Console.ReadLine();
                try
                {
                BaseHero hero = CreateHero(name, type);
                heros.Add(hero);

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

               
            }

            int bossPower = int.Parse(Console.ReadLine());
            int heroesPower = heros.Sum(p => p.Power);

            foreach (var hero in heros)
            {
                Console.WriteLine(hero.CastAbility());
            }

            if (heroesPower >= bossPower)
            {
                Console.WriteLine("Victory!");

            }
            else
            {
                Console.WriteLine("Defeat...");
            }

        }

        private static BaseHero CreateHero(string name, string type)
        {

            if (type == nameof(Druid))
            {
                return new Druid(name);
            }
            else if (type == nameof(Paladin))
            {
                return new Paladin(name);
            }
            else if (type == nameof(Rogue))
            {
                return new Rogue(name);
            }
            else if (type == nameof(Warrior))
            {
                return new Warrior(name);
            }

            throw new Exception("Invalid hero!");
            
        }
    }
}
