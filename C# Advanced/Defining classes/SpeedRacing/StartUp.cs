using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            Car[] cars = new Car[numberOfCars];
            for (int i = 0; i < numberOfCars; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                double fuelAmount = double.Parse(input[1]);
                double fuelConsumption = double.Parse(input[2]);
                cars[i]=new Car(model,fuelAmount,fuelConsumption);
            }
            while (true)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "End")
                {
                    break;
                }
                else
                {
                    string carModel = input[1];
                    double kmToTravel = double.Parse(input[2]);
                    cars.Where(c => c.model == carModel).ToList().ForEach(c => c.Drive(kmToTravel));
                }
           
            }
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.model} {car.fuelAmount:f2} {car.travelledDistance}");
            }
        }
    }
}
