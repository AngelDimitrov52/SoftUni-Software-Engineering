using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniParking
{
    public class Parking
    {
        public List<Car> cars;
        private int capacity;
        

        public Parking(int capaciti)
        {
            capacity = capaciti;
            cars = new List<Car>(capaciti);
            
        }
        public int Count => cars.Count;
        

        public string AddCar(Car car)
        {
            if (cars.Contains(car))
            {
                return "Car with that registration number, already exists!";
            }
            if (cars.Count >= capacity)
            {
                return "Parking is full!";
            }
            cars.Add(car);
            
            return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
        }

        public string RemoveCar(string registrationNumber)
        {
            var removeCar = cars.FirstOrDefault(n => n.RegistrationNumber == registrationNumber);
            if (removeCar == null)
            {
                return "Car with that registration number, doesn't exist!";
            }

            cars.Remove(removeCar);   
            return $"Successfully removed {registrationNumber}";
        }
        public Car GetCar(string registrationNumber)
        {
            var car = cars.FirstOrDefault(n => n.RegistrationNumber == registrationNumber);
            return car;
        }
        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            int n = cars.Count;
            for (int i = 0; i < n; i++)
            {
                foreach (var regNum in registrationNumbers)
                {
                    if (cars[i].RegistrationNumber == regNum)
                    {
                        cars.Remove(cars[i]); 
                        n--;
                    }
                }
            }
        }
    }
}
