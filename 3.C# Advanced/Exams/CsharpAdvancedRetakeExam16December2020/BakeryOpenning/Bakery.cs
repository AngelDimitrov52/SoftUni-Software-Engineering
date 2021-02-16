using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BakeryOpenning
{
    public class Bakery
    {
        private List<Employee> data;

        public Bakery(string name, int capacity)
        {
            Capacity = capacity;
            Name = name;
            data = new List<Employee>(capacity);

        }
        public string Name { get; }
        public int Capacity { get; }
        public int Count { get => data.Count; }

        public void Add(Employee employee)
        {
            if (data.Count < Capacity)
            {
                data.Add(employee);
            }
        }
        public bool Remove(string name)
        {
            foreach (var item in data)
            {
                if (item.Name == name)
                {
                    data.Remove(item);
                    return true;
                }
            }
            return false;
        }
        public Employee GetOldestEmployee()
        {
            return data.OrderByDescending(n => n.Age).FirstOrDefault();
        }
        public Employee GetEmployee(string name)
        {
            foreach (var item in data)
            {
                if (item.Name == name)
                {
                    return item;
                }
            }
            return null;
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Employees working at Bakery {this.Name}:");
            foreach (var item in data)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }
    }
}
