using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo
{
    public class Pet : IPet, IBirthable
    {
        public Pet(string name , string birthDate)
        {
            PetName = name;
            Birthdate = birthDate;
        }
        public string PetName { get; private set; }

        public string Birthdate { get; private set; }
    }
}
