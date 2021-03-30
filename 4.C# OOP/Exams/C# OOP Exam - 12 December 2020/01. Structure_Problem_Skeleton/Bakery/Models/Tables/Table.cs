using Bakery.Models.BakedFoods.Contracts;
using Bakery.Models.Drinks.Contracts;
using Bakery.Models.Tables.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bakery.Models.Tables
{
    public abstract class Table : ITable
    {
        private readonly List<IBakedFood> FoodOrders;
        private readonly List<IDrink> DrinkOrders;

        private int capacity;
        private int numberOfPeople;

        public Table(int tableNumber, int capacity, decimal pricePerPerson)
        {
            FoodOrders = new List<IBakedFood>();
            DrinkOrders = new List<IDrink>();

            TableNumber = tableNumber;
            Capacity = capacity;
            PricePerPerson = pricePerPerson;

            IsReserved = false;

        }

        public int TableNumber { get; private set; }

        public int Capacity
        {
            get => capacity;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Capacity has to be greater than 0");
                }
                capacity = value;
            }
        }

        public int NumberOfPeople
        {
            get => numberOfPeople;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Cannot place zero or less people!");
                }
                numberOfPeople = value;
            }
        }

        public decimal PricePerPerson
        {
            get;
            private set;
        }

        public bool IsReserved
        {
            get;
            private set;
        }

        public decimal Price => PricePerPerson * NumberOfPeople;

        public void Clear()
        {
            FoodOrders.Clear();
            DrinkOrders.Clear();

            IsReserved = false;
            numberOfPeople = 0;
        }

        public decimal GetBill()
        {
            decimal foodPrice = FoodOrders.Sum(p => p.Price);
            decimal drinkPrice = DrinkOrders.Sum(p => p.Price);

            decimal result = foodPrice + drinkPrice + Price;
            return result;
        }

        public string GetFreeTableInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Table: {TableNumber}");
            sb.AppendLine($"Type: {GetType().Name}");
            sb.AppendLine($"Capacity: {Capacity}");
            sb.AppendLine($"Price per Person: {PricePerPerson}");

            return sb.ToString().Trim();
        }

        public void OrderDrink(IDrink drink)
        {
            DrinkOrders.Add(drink);
        }

        public void OrderFood(IBakedFood food)
        {
            FoodOrders.Add(food);
        }

        public void Reserve(int numberOfPeople)
        {
            NumberOfPeople = numberOfPeople;
            IsReserved = true;
        }
    }
}
