using Bakery.Core.Contracts;
using Bakery.Models.BakedFoods;
using Bakery.Models.BakedFoods.Contracts;
using Bakery.Models.Drinks;
using Bakery.Models.Drinks.Contracts;
using Bakery.Models.Tables;
using Bakery.Models.Tables.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bakery.Core
{
    public class Controller : IController
    {
        private List<IBakedFood> bakedFoods;
        private List<IDrink> drinks;
        private List<ITable> tables;

        private decimal totalIncome;

        public Controller()
        {
            bakedFoods = new List<IBakedFood>();
            drinks = new List<IDrink>();
            tables = new List<ITable>();

            totalIncome = 0;
        }
        public string AddDrink(string type, string name, int portion, string brand)
        {
            IDrink drink = null;
            if (type == nameof(Tea))
            {
                drink = new Tea(name, portion, brand);
            }
            else if (type == nameof(Water))
            {
                drink = new Water(name, portion, brand);
            }

            drinks.Add(drink);

            return $"Added {drink.Name} ({drink.Brand}) to the drink menu";


        }

        public string AddFood(string type, string name, decimal price)
        {
            IBakedFood food = null;
            if (type == nameof(Bread))
            {
                food = new Bread(name, price);
            }
            else if (type == nameof(Cake))
            {
                food = new Cake(name, price);
            }

            bakedFoods.Add(food);

            return $"Added {food.Name} ({food.GetType().Name}) to the menu";
        }

        public string AddTable(string type, int tableNumber, int capacity)
        {
            ITable table = null;
            if (type == nameof(InsideTable))
            {
                table = new InsideTable(tableNumber, capacity);
            }
            else if (type == nameof(OutsideTable))
            {
                table = new OutsideTable(tableNumber, capacity);
            }

            tables.Add(table);

            return $"Added table number {table.TableNumber} in the bakery";
        }

        public string GetFreeTablesInfo()
        {
            StringBuilder sb = new StringBuilder();
            foreach (ITable table in tables.Where(p => p.IsReserved == false))
            {
                sb.AppendLine(table.GetFreeTableInfo());
            }

            return sb.ToString().Trim();
        }

        public string GetTotalIncome() => $"Total income: {totalIncome:f2}lv";


        public string LeaveTable(int tableNumber)
        {
            ITable table = tables.FirstOrDefault(p => p.TableNumber == tableNumber);

            decimal bill = table.GetBill();
            totalIncome += table.GetBill();

            table.Clear();

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Table: {tableNumber}");
            sb.AppendLine($"Bill: {bill:f2}");

            return sb.ToString().TrimEnd();
        }

        public string OrderDrink(int tableNumber, string drinkName, string drinkBrand)
        {
            ITable table = tables.FirstOrDefault(p => p.TableNumber == tableNumber);
            IDrink drink = drinks.FirstOrDefault(p => p.Name == drinkName);

            if (table == null)
            {
                return $"Could not find table {tableNumber}";
            }

            if (drink == null || drink.Brand != drinkBrand)
            {
                return $"There is no {drinkName} {drinkBrand} available";
            }

            table.OrderDrink(drink);
            return $"Table {table.TableNumber} ordered {drink.Name} {drink.Brand}";
        }

        public string OrderFood(int tableNumber, string foodName)
        {
            ITable table = tables.FirstOrDefault(p => p.TableNumber == tableNumber);
            IBakedFood food = bakedFoods.FirstOrDefault(p => p.Name == foodName);

            if (table == null)
            {
                return $"Could not find table {tableNumber}";
            }

            if (food == null)
            {
                return $"No {foodName} in the menu";
            }

            table.OrderFood(food);

            return $"Table {table.TableNumber} ordered {food.Name}";
        }

        public string ReserveTable(int numberOfPeople)
        {
            var notReservet = tables.Where(p => p.IsReserved == false);
            ITable table = notReservet.FirstOrDefault(p => p.Capacity >= numberOfPeople);

            if (table == null)
            {
                return $"No available table for {numberOfPeople} people";
            }

            table.Reserve(numberOfPeople);

            return $"Table {table.TableNumber} has been reserved for {numberOfPeople} people";
        }
    }
}
