using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Car
    {
        public string Model { get; private set; }
        public Engine Engine { get; private set; }
        public int Weight { get; private set; }
        public string Color { get; private set; }
        public Car(string model, Engine engine, int weight, string color)
        {
            Model = model;
            Engine = engine;
            Weight = weight;
            Color = color;
        }
        public Car(string model, Engine engine)
        {
            Model = model;
            Engine = engine;
            Weight = 0;
            Color = "n/a";
        }
        public Car(string model, Engine engine,int weight)
        {
            Model = model;
            Engine = engine;
            Weight = weight;
            Color = "n/a";
        }
        public Car(string model, Engine engine, string color)
        {
            Model = model;
            Engine = engine;
            Weight = 0;
            Color = color;
        }
        public override string ToString()
        {
            string displacement = "";
            string weight = "";
            if (Weight == 0)
            {
                weight = "n/a";
            }
            else
            {
                weight = Weight + "";
            }
            if (Engine.Displacement == 0)
            {
                displacement = "n/a";
            }
            else
            {
                displacement = Engine.Displacement + "";
            }

            return $"{Model}:" + Environment.NewLine +
                $"  {Engine.Model}:" + Environment.NewLine + 
                $"    Power: {Engine.Power}" + Environment.NewLine +
                $"    Displacement: {displacement}" + Environment.NewLine +
                $"    Efficiency: {Engine.Efficiency}" + Environment.NewLine +
                $"  Weight: {weight}" + Environment.NewLine +
                $"  Color: {Color}" + Environment.NewLine;

        }
    }
}
