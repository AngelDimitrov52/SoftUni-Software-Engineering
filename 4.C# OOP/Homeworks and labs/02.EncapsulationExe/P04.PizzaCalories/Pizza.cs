using System;
using System.Collections.Generic;
using System.Text;

namespace P04.PizzaCalories
{
    public class Pizza
    {
        private string name;
        private List<Topping> toppingsList;
        private double toppingTotalCal;


        public Pizza(string name)
        {
            Name = name;
            toppingsList = new List<Topping>();
        }
        public string Name
        {
            get => name;
            private set
            {
                if (value.Length >= 1 && value.Length <= 15)
                {
                    name = value;
                }
                else
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
            }
        }
        public Dough Dougt { get; set; }
        public int Numberoftoppings => toppingsList.Count;
        public double Calories => GetTotalCal();



        public void AddTopping(Topping top)
        {
            if (toppingsList.Count < 10)
            {
                toppingsList.Add(top);
                toppingTotalCal += top.Calories;
            }
            else
            {
                throw new Exception("Number of toppings should be in range [0..10].");
            }
        }
        private double GetTotalCal()
        {
            return this.Dougt.Calories + toppingTotalCal;
        }

    }
}
