using AquaShop.Models.Decorations.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AquaShop.Repositories.Contracts
{
    public class DecorationRepository : IRepository<IDecoration>
    {
        private List<IDecoration> decorations;
        public DecorationRepository()
        {
            decorations = new List<IDecoration>();
        }
        public IReadOnlyCollection<IDecoration> Models => decorations;

        public void Add(IDecoration model)
        {
            decorations.Add(model);
        }

        public IDecoration FindByType(string type)
        {
            IDecoration decoration = decorations.FirstOrDefault(p => p.GetType().Name == type);
            return decoration;
        }

        public bool Remove(IDecoration model)
        {

            if (decorations.Any(p => p.GetType().Name == model.GetType().Name))
            {
                decorations.Remove(model);
                return true;

            }
            return false;

        }
    }
}
