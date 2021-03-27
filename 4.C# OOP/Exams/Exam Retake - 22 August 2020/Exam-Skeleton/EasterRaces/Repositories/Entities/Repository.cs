using EasterRaces.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasterRaces.Repositories.Entities
{
    public abstract class Repository<T>: IRepository<T>
    {
        private readonly List<T> list;
        public Repository()
        {
            List = new List<T>();
        }
        protected List<T> List
        { get => list;
            set
            {
                List = value;
            }
        }
        public void Add(T model)
        {
            list.Add(model);
        }

        public IReadOnlyCollection<T> GetAll()
        {
            return list;
        }

        public abstract T GetByName(string name);
       

        public bool Remove(T model)
        {
           return list.Remove(model);
        }
    }
}
