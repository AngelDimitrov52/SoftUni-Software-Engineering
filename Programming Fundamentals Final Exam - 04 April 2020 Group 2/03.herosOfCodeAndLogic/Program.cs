using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.herosOfCodeAndLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<int>> heros = new Dictionary<string, List<int>>();

            for (int i = 0; i < n; i++)
            {
                string[] comandArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = comandArgs[0];
                int hp = int.Parse(comandArgs[1]);
                int mp = int.Parse(comandArgs[2]);

                List<int> hm = new List<int>()
                {
                    hp,
                    mp
                };
                heros.Add(name, hm);
            }

            string comand;
            while ((comand = Console.ReadLine()) != "End")
            {
                string[] comandArgs = comand.Split(" - ",StringSplitOptions.RemoveEmptyEntries);
                string cmd = comandArgs[0];
                string heroName = comandArgs[1];

                if (cmd == "CastSpell")
                {
                    int heroMp = heros[heroName][1];
                    int mpNeeded = int.Parse(comandArgs[2]);
                    string spellName = comandArgs[3];
                    if (mpNeeded > heroMp)
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }
                    else
                    {
                        heros[heroName][1] -= mpNeeded;
                        heroMp = heros[heroName][1];
                        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroMp} MP!");
                    }
                }
                else if (cmd == "TakeDamage")
                {
                    int demige = int.Parse(comandArgs[2]);
                    string atajername = comandArgs[3];
                    heros[heroName][0] = heros[heroName][0] - demige;
                    if (heros[heroName][0] <= 0)
                    {
                        Console.WriteLine($"{heroName} has been killed by {atajername}!");
                        heros.Remove(heroName);
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} was hit for {demige} " +
                            $"HP by {atajername} and now has {heros[heroName][0]} HP left!");
                    }

                }
                else if (cmd == "Recharge")
                {
                    int amount = int.Parse(comandArgs[2]);
                    int midMP = heros[heroName][1];
                    heros[heroName][1] += amount;
                    if (heros[heroName][1] > 200)
                    {
                        heros[heroName][1] = 200;
                        amount = heros[heroName][1] - midMP;
                    }
                    Console.WriteLine($"{heroName} recharged for {amount} MP!");
                }
                else if (cmd == "Heal")
                {
                    int amount = int.Parse(comandArgs[2]);
                    int midHp = heros[heroName][0];
                    heros[heroName][0] += amount;
                    if (heros[heroName][0] > 100)
                    {
                        heros[heroName][0] = 100;
                        amount = heros[heroName][0] - midHp;
                    }
                    Console.WriteLine($"{heroName} healed for {amount} HP!");
                }
            }
            foreach (var item in heros.OrderByDescending(x=>x.Value[0]).ThenBy(k=>k.Key))
            {
                Console.WriteLine($"{item.Key}");
                Console.WriteLine($"HP: {item.Value[0]}");
                Console.WriteLine($"MP: {item.Value[1]}");
            }


        }
    }
}
