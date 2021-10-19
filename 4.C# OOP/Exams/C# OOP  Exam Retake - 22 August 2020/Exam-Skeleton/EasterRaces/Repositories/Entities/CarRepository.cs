using EasterRaces.Models.Cars.Contracts;
using EasterRaces.Repositories.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace EasterRaces.Repositories.Entities
{
    public class CarRepository : IRepository<ICar>
    {
        private readonly List<ICar> list;
        public CarRepository()
        {
            list = new List<ICar>();
        }
        public void Add(ICar model)
        {
            list.Add(model);
        }

        public IReadOnlyCollection<ICar> GetAll()
        {
            return list.ToArray();
        }

        public ICar GetByName(string name)
        {
            ICar result = list.FirstOrDefault(p => p.Model == name);
            return result;
        }

        public bool Remove(ICar model)
        {
            return list.Remove(model);
        }
    }
}
