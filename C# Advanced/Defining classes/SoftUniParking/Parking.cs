using System;
using System.Collections.Generic;
using System.Text;

namespace SoftUniParking
{
    public class Parking
    {
        public Dictionary<string,Car> cars;
        private int capacity;
        

        public Parking(int capacity)
        {
            cars = new Dictionary<string, Car>();
            this.capacity = capacity;
        }
        public string AddCar(Car car)
        {
            string carMake = car.Make;
            string carRegistration = car.RegistrationNumber;
            if (cars.ContainsKey(car.RegistrationNumber))
            {
                
                
                return "Car with that registration number, already exists!";
            }
            if (cars.Count==capacity)
            {
                
                return "Parking is full!";
            }
            cars.Add(car.RegistrationNumber, car);
            return $"Successfully added new car {carMake} {carRegistration}";
        }
        public  string RemoveCar(string registrationNumber)
        {
            if (!cars.ContainsKey(registrationNumber))
            {
                return"Car with that registration number, doesn't exist!";
            }
            else
            {
                cars.Remove(registrationNumber);
                return$"Successfully removed {registrationNumber}";
            }
        }
        public string GetCar(string registrationNumber)
        {
            return cars[registrationNumber].ToString();
        }
        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            foreach (var registration in registrationNumbers)
            {
                if (cars.ContainsKey(registration))
                {
                    cars.Remove(registration);
                }
            }
        }
        public int Count
        {
            get => cars.Count;
        }

        
    }
}
