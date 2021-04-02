using EasterRaces.Core.Contracts;
using EasterRaces.Models.Cars.Contracts;
using EasterRaces.Models.Cars.Entities;
using EasterRaces.Models.Drivers.Contracts;
using EasterRaces.Models.Drivers.Entities;
using EasterRaces.Models.Races.Contracts;
using EasterRaces.Models.Races.Entities;
using EasterRaces.Repositories.Contracts;
using EasterRaces.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasterRaces.Core.Entities
{
    public class ChampionshipController : IChampionshipController
    {
        private readonly IRepository<IDriver> driversRepository;
        private readonly IRepository<ICar> carsRepository;
        private readonly IRepository<IRace> raceRepository;

        public ChampionshipController()
        {
            driversRepository = new DriverRepository();
            carsRepository = new CarRepository();
            raceRepository = new RaceRepository();
        }

        public string AddCarToDriver(string driverName, string carModel)
        {
            ICar car = carsRepository.GetByName(carModel);
            IDriver driver = driversRepository.GetByName(driverName);

            if (driver == null)
            {
                throw new InvalidOperationException($"Driver {driverName} could not be found.");
            }

            else if (car == null)
            {
                throw new InvalidOperationException($"Car {carModel} could not be found.");
            }

            driver.AddCar(car);

            return $"Driver {driverName} received car {carModel}.";
        }

        public string AddDriverToRace(string raceName, string driverName)
        {
            IRace race = raceRepository.GetByName(raceName);
            IDriver driver = driversRepository.GetByName(driverName);

            if (race == null)
            {
                throw new InvalidOperationException($"Race {raceName} could not be found.");
            }
            else if (driver == null)
            {
                throw new InvalidOperationException($"Driver { driverName } could not be found.");
            }

            race.AddDriver(driver);
            return $"Driver {driverName} added in {raceName} race.";
        }

        public string CreateCar(string type, string model, int horsePower)
        {
            ICar car = carsRepository.GetByName(model);
            if (car != null)
            {
                throw new ArgumentException("Car {model} is already created.");
            }

            if (type == "Muscle")
            {
                car = new MuscleCar(model, horsePower);
            }
            else if (type == "Sports")
            {
                car = new SportsCar(model, horsePower);
            }

            carsRepository.Add(car);

            return $"{car.GetType().Name} {model} is created.";
        }

        public string CreateDriver(string driverName)
        {
            IDriver driver = driversRepository.GetByName(driverName);
            if (driver != null)
            {
                throw new ArgumentException($"Driver {driverName} is already created.");
            }

            driver = new Driver(driverName);
            driversRepository.Add(driver);

            return $"Driver {driverName} is created.";
        }

        public string CreateRace(string name, int laps)
        {
            IRace race = raceRepository.GetByName(name);

            if (race != null)
            {
                throw new InvalidOperationException($"Race {name} is already create.");
            }

            race = new Race(name, laps);
            raceRepository.Add(race);

            return $"Race {name} is created.";
        }

        public string StartRace(string raceName)
        {
            IRace race = raceRepository.GetByName(raceName);

            if (race == null)
            {
                throw new InvalidOperationException($"Race { raceName } could not be found.");
            }
            if (race.Drivers.Count < 3)
            {
                throw new InvalidOperationException($"Race {raceName} cannot start with less than 3 participants.");
            }

            var list = race.Drivers.OrderByDescending(p => p.Car.CalculateRacePoints(race.Laps)).ToList();
            var driver1 = list[0];
            var driver2 = list[1];
            var driver3 = list[2];

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Driver {driver1.Name} wins {raceName} race.");
            sb.AppendLine($"Driver {driver2.Name} is second in {raceName} race.");
            sb.AppendLine($"Driver {driver3.Name} is third in {raceName} race.");

            string result = sb.ToString().TrimEnd();

            raceRepository.Remove(race);

            return result;
        }
    }
}
