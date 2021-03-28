using EasterRaces.Models.Drivers.Contracts;
using EasterRaces.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasterRaces.Repositories.Entities
{
    public class DriverRepository : IRepository<IDriver>
    {
        private readonly List<IDriver> list;
        public DriverRepository()
        {
            list = new List<IDriver>();
        }
        public void Add(IDriver model)
        {
            list.Add(model);
        }

        public IReadOnlyCollection<IDriver> GetAll()
        {
            return list.ToArray();
        }

        public IDriver GetByName(string name)
        {
            IDriver result = list.FirstOrDefault(p => p.Name == name);
            return result;
        }

        public bool Remove(IDriver model)
        {
            return list.Remove(model);
        }
    }
}
