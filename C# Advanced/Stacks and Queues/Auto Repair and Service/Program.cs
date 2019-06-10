using System;
using System.Collections.Generic;
using System.Linq;

namespace Auto_Repair_and_Service
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            Queue<string> carsForService = new Queue<string>(cars);
            Queue<string> servicedCars = new Queue<string>();
            while (true)
            {
                string[] command = Console.ReadLine().Split("-");
                if (command[0] == "End")
                {
                    break;
                }
                if (command[0] == "Service"&&carsForService.Count!=0)
                {
                    string servicedCar = carsForService.Dequeue();
                    Console.WriteLine($"Vehicle {servicedCar} got served.");
                    servicedCars.Enqueue(servicedCar);
                }else if (command[0] == "History")
                {
                    List<string> reversed = servicedCars.Reverse().ToList();
                    Console.WriteLine(string.Join(", ",reversed));
                }else if(command[0] == "CarInfo")
                {
                    if (servicedCars.Contains(command[1]))
                    {
                        Console.WriteLine("Served.");
                    }
                    else
                    {
                        Console.WriteLine("Still waiting for service.");

                    }
                }

            }
            List<string> sr = servicedCars.Reverse().ToList();
            if (carsForService.Count != 0)
            {
                Console.WriteLine($"Vehicles for service: {string.Join(", ", carsForService)}");

            }
            if (sr.Count != 0)
            {
                Console.WriteLine($"Served vehicles: {string.Join(", ", sr)}");

            }


        }
    }
}
