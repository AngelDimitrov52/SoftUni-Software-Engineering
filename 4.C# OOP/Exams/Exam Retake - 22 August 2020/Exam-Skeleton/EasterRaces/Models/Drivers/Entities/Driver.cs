using EasterRaces.Models.Cars.Contracts;
using EasterRaces.Models.Cars.Entities;
using EasterRaces.Models.Drivers.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasterRaces.Models.Drivers.Entities
{
    public class Driver : IDriver
    {
        private string name;
        private bool canParticipate;
        public Driver(string name)
        {
            Name = name;
            CanParticipate = false;
            NumberOfWins = 0;
            Car = null;
        }
        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 5)
                {
                    throw new ArgumentException($"Name {value} cannot be less than 5 symbols.");
                }
                name = value;
            }
        }

        public ICar Car { get; private set; }

        public int NumberOfWins { get; private set; }

        public bool CanParticipate
        {
            get => canParticipate;
            private set
            {
                if (Car == null)
                {
                    canParticipate = false;
                }
                else
                {
                    canParticipate = true;
                }
            }
        }

        public void AddCar(ICar car)
        {
            if (car == null)
            {
                throw new ArgumentNullException(nameof(ICar), $"Car cannot be null.");

            }
            Car = car;
        }

        public void WinRace()
        {
            NumberOfWins++;
        }
    }
}
