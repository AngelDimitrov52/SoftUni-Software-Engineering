using System;
using System.Collections.Generic;
using System.Text;

namespace P09.ExplicitInterfaces
{
    public interface IPerson
    {
        public string Name { get; }
        public int Age { get; }

        string GetName();
    }
}
