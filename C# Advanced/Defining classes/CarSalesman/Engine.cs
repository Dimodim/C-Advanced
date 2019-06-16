using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Engine
    {
        public string Model { get; private set; }
        public string Power { get; private set; }
        public int Displacement { get; private set; }
        public string Efficiency { get; private set; }
        public Engine(string model, string power)
        {
            Model = model;
            Power = power;
            Displacement = 0;
            Efficiency = "n/a";
        }
        public Engine(string model, string power, int dissplacement)
        {
            Model = model;
            Power = power;
            Displacement = dissplacement;
            Efficiency = "n/a";
        }
        public Engine(string model, string power, string efficiency)
        {
            Model = model;
            Power = power;
            Displacement = 0;
            Efficiency = efficiency;
        }
        public Engine(string model, string power, int displacement, string efficiency)
        {
            Model = model;
            Power = power;
            Displacement = displacement;
            Efficiency = efficiency;
        }
    }
}
