using System;
using System.Collections.Generic;
using System.Text;

namespace P09.ExplicitInterfaces
{
    public interface IResident
    {
        public string Name { get; }
        public string Country { get; }

        string GetName();
    }
}
