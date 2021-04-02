using EasterRaces.Models.Races.Contracts;
using EasterRaces.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasterRaces.Repositories.Entities
{
    public class RaceRepository : IRepository<IRace>
    {
        private readonly List<IRace> list;
        public RaceRepository()
        {
            list = new List<IRace>();
        }
        public void Add(IRace model)
        {
            list.Add(model);
        }

        public IReadOnlyCollection<IRace> GetAll()
        {
            return list.ToArray();
        }

        public IRace GetByName(string name)
        {
            IRace result = list.FirstOrDefault(p => p.Name == name);
            return result;
        }

        public bool Remove(IRace model)
        {
            return list.Remove(model);
        }
    }
}
