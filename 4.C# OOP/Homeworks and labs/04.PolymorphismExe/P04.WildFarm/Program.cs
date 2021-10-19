using P04.WildFarm.AbstractAnimals;
using P04.WildFarm.Animals;
using P04.WildFarm.Foods;
using System;
using System.Collections.Generic;

namespace P04.WildFarm
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            string comand;
            while ((comand = Console.ReadLine()) != "End")
            {
                string[] animalInfo = comand.Split();
                Animal animal = CreateAnimal(animalInfo);

                animal.Talk();
                animals.Add(animal);

                string[] foodInfo = Console.ReadLine().Split();
                Food food = CreateFood(foodInfo);
                try
                {
                animal.EatFood(food);

                }
                catch (ArgumentException ex)
                {

                    Console.WriteLine(ex.Message);
                }


            }
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }

        private static Food CreateFood(string[] foodInfo)
        {
            string type = foodInfo[0];
            int quantity = int.Parse(foodInfo[1]);

            Food food = null;
            if (type == nameof(Fruit))
            {
                food = new Fruit(quantity);
            }
            else if (type == nameof(Meat))
            {
                food = new Meat(quantity);
            }
            else if (type == nameof(Seeds))
            {
                food = new Seeds(quantity);
            }
            else if (type == nameof(Vegetable))
            {
                food = new Vegetable(quantity);
            }

            return food;
        }

        private static Animal CreateAnimal(string[] animalInfo)
        {
            string type = animalInfo[0];
            string name = animalInfo[1];
            double weight = double.Parse(animalInfo[2]);

            Animal animal = null;

            if (type == nameof(Cat))
            {
                animal = new Cat(name, weight, animalInfo[3], animalInfo[4]);
            }
            else if (type == nameof(Tiger))
            {
                animal = new Tiger(name, weight, animalInfo[3], animalInfo[4]);
            }
            else if (type == nameof(Dog))
            {
                animal = new Dog(name, weight, animalInfo[3]);
            }
            else if (type == nameof(Mouse))
            {
                animal = new Mouse(name, weight, animalInfo[3]);
            }
            else if (type == nameof(Hen))
            {
                animal = new Hen(name, weight, double.Parse(animalInfo[3]));
            }
            else if (type == nameof(Owl))
            {
                animal = new Owl(name, weight, double.Parse(animalInfo[3]));
            }

            return animal;

        }
    }
}
