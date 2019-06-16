using System;
using System.Collections.Generic;

namespace CarSalesman
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int enginesRequire = int.Parse(Console.ReadLine());
            var engines = new Dictionary<string,Engine>();
            for (int i = 0; i < enginesRequire; i++)
            {
                string[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                if (input.Length == 4)
                {
                    string model = input[0];
                    string power = input[1];
                    int displacement = int.Parse(input[2]);
                    string efficiency = input[3];
                    Engine engine = new Engine(model,power,displacement,efficiency);
                    engines.Add(engine.Model,engine);
                }
                else if (input.Length == 2)
                {
                    string model = input[0];
                    string power = input[1];
                    Engine engine = new Engine(model, power);
                    engines.Add(engine.Model, engine);
                }
                else
                {
                    char[] toChar = input[2].ToCharArray();
                    if (!Char.IsDigit(toChar[0]))
                    {
                        string model = input[0];
                        string power = input[1];
                        string efficiency = input[2];
                        Engine engine = new Engine(model, power, efficiency);
                        engines.Add(engine.Model, engine);
                    }
                    else
                    {
                        string model = input[0];
                        string power = input[1];
                        int dissplacement = int.Parse(input[2]);
                        Engine engine = new Engine(model, power, dissplacement);
                        engines.Add(engine.Model, engine);
                    }
                }
            }
            int carsRequire = int.Parse(Console.ReadLine());
            var cars = new List<Car>();
            for (int i = 0; i < carsRequire; i++)
            {
                string[] input = Console.ReadLine().Split();
                if (input.Length == 4)
                {
                    string model = input[0];
                    string engine = input[1];
                    int weight = int.Parse(input[2]);
                    string color = input[3];
                    Car car = new Car(model, engines[engine], weight, color);
                    cars.Add(car);
                }
                else if(input.Length == 2)
                {
                    string model = input[0];
                    string engine = input[1];
                    Car car = new Car(model, engines[engine]);
                    cars.Add(car);


                }
                else
                {
                    char[] toChar = input[2].ToCharArray();
                    if (!Char.IsDigit(toChar[0]))
                    {
                        string model = input[0];
                        string engine = input[1];
                        string color = input[2];
                        Car car = new Car(model, engines[engine], color);
                        cars.Add(car);
                    }
                    else
                    {
                        string model = input[0];
                        string engine = input[1];
                        int weight =int.Parse( input[2]);
                        Car car = new Car(model, engines[engine], weight);
                        cars.Add(car);
                    }
                }
            }
            foreach(var car in cars)
            {
                Console.Write(car.ToString());
            }
        }
    }
}
