using System;

namespace P04.PizzaCalories
{
    public class Program
    {
        static void Main(string[] args)
        {

            try
            {
                string[] pizzaname = Console.ReadLine().Split();
                Pizza pizza = new Pizza(pizzaname[1]);

                string[] doughName = Console.ReadLine().Split();
                pizza.Dougt = new Dough(doughName[1], doughName[2], int.Parse(doughName[3]));

                string comand;
                while ((comand = Console.ReadLine()) != "END")
                {
                    string[] toppingName = comand.Split();
                    Topping top = new Topping(toppingName[1], int.Parse(toppingName[2]));
                    pizza.AddTopping(top);

                }

                Console.WriteLine($"{pizza.Name} - {pizza.Calories:F2} Calories.");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
