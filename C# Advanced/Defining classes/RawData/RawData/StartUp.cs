using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = info[0];
                
                int engineSpeed = int.Parse(info[1]);
                int enginePower = int.Parse(info[2]);

                Engine engine = new Engine(engineSpeed, enginePower);

                int cargoWeight = int.Parse(info[3]);
                string cargoType = info[4];

                Cargo cargo = new Cargo(cargoWeight, cargoType);

                var tires = new Tire[]
                {
                    new Tire(int.Parse(info[6]), double.Parse(info[5])),
                    new Tire(int.Parse(info[8]), double.Parse(info[7])),
                    new Tire(int.Parse(info[10]), double.Parse(info[9])),
                    new Tire(int.Parse(info[12]), double.Parse(info[11])),
                };

                Car car = new Car(tires, engine, cargo,model);
                cars.Add(car);
                
                
            }
            string command = Console.ReadLine();
            HashSet<Car> carsToPrint = new HashSet<Car>();
            if(command== "fragile")
            {
                foreach (var car in cars)
                {
                    if (car.CargoWeightAndType.cargoType == "fragile")
                    {
                        foreach (var tire in car.Tires)
                        {
                            if (tire.TirePressure < 1)
                            {
                                carsToPrint.Add(car);
                                break;
                            }
                        }
                    }
                    
                }
            }
            else if (command == "flamable")
            {
                foreach (var car in cars)
                {
                    if (car.CargoWeightAndType.cargoType == "flamable")
                    {
                        if (car.SpeedAndPower.Power > 250)
                        {
                            carsToPrint.Add(car);
                        }
                    }

                }
            }
            foreach (var car in carsToPrint)
            {
                Console.WriteLine(car.Model);
            }
        }
    }
}
