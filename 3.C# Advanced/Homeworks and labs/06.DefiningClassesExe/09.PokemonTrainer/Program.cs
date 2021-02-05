using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.PokemonTrainer
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Trainers> trainers = new List<Trainers>();
            string comand;
            while ((comand = Console.ReadLine()) != "Tournament")
            {
                string[] trainerInfo = comand.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Trainers currentTrainer = new Trainers();

                Pokemon poke = new Pokemon(trainerInfo[1], trainerInfo[2], int.Parse(trainerInfo[3]));

                string name = trainerInfo[0];
                Trainers trainer = trainers.FirstOrDefault(x => x.Name == name);

                if (trainer == null)
                {
                    currentTrainer.Name = name;
                    currentTrainer.Pokemons.Add(poke);
                    trainers.Add(currentTrainer);
                }
                else
                {
                    trainer.Pokemons.Add(poke);
                }
            }
            while ((comand = Console.ReadLine()) != "End")
            {
                foreach (var item in trainers)
                {
                    {
                        if (item.Pokemons.Any(e => e.Element == comand))
                        {
                            item.NumberOfBags++;
                        }
                        else
                        {
                            foreach (var pokemons in item.Pokemons)
                            {
                                pokemons.ReductHealth();
                            }
                        }
                    }
                }
                foreach (var item in trainers)
                {
                    item.Pokemons.RemoveAll(n => n.Health <= 0);
                }
            }

            foreach (var item in trainers.OrderByDescending(x => x.NumberOfBags))
            {
                Console.WriteLine($"{item.Name} {item.NumberOfBags} {item.Pokemons.Count}");
            }
        }
    }
}
