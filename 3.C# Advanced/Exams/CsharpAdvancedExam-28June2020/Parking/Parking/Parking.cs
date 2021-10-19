using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking
{
    public class Parking
    {
        private List<Car> data;

        public Parking(string type, int capacity)
        {
            Type = type;
            Capacity = capacity;
            data = new List<Car>(capacity);
        }
        public string Type { get; set; }
        public int Capacity { get; set; }
        public int Count { get => data.Count; }

        public void Add(Car car)
        {
            if (data.Count < Capacity)
            {
                data.Add(car);
            }
        }

        public bool Remove(string manufacturer, string model)
        {
            foreach (var item in data)
            {
                if (item.Manufacturer == manufacturer)
                {
                    if (item.Model == model)
                    {
                        data.Remove(item);
                        return true;
                    }
                }
            }
            return false;
        }
        public Car GetLatestCar()
        {
            List<Car> sortCar = data.OrderByDescending(n => n.Year).ToList();
            return sortCar.FirstOrDefault();
        }
        public Car GetCar(string manufacturer, string model)
        {
            foreach (var item in data)
            {
                if (item.Manufacturer == manufacturer)
                {
                    if (item.Model == model)
                    {
                        return item;
                    }
                }
            }
            return null;
        }
        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The cars are parked in {Type}:");
            foreach (var item in data)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString().Trim();
        }

    }
}
