using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.ShoppingSpree
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Person> persons = new Dictionary<string, Person>();
            Dictionary<string, Product> products = new Dictionary<string, Product>();

            try
            {
                string[] firstPersons = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

                foreach (var person in firstPersons)
                {
                    string[] elements = person.Split("=", StringSplitOptions.RemoveEmptyEntries);
                    string name = elements[0];
                    int money = int.Parse(elements[1]);
                    Person per = new Person(name, money);
                    persons.Add(name, per);
                }


                string[] secondProducts = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
                foreach (string produst in secondProducts)
                {
                    string[] elements = produst.Split("=", StringSplitOptions.RemoveEmptyEntries);
                    string name = elements[0];
                    int cost = int.Parse(elements[1]);
                    Product per = new Product(name, cost);
                    products.Add(name, per);
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return;
            }

            string comand;
            while ((comand = Console.ReadLine()) != "END")
            {
                string[] comandArgs = comand.Split();
                string personName = comandArgs[0];
                string productName = comandArgs[1];

                Person thisPerson = persons[personName];
                Product thisProduct = products[productName];

                thisPerson.AddProduct(thisProduct);

            }

            foreach (var person in persons)
            {
                if (person.Value.Bag.Count == 0)
                {
                    Console.WriteLine($"{person.Value.Name} - Nothing bought");
                }
                else
                {
                    Console.WriteLine($"{person.Value.Name} - {string.Join(", ", person.Value.Bag.Select(p => p.Name))}");
                }
            }
        }
    }
}
