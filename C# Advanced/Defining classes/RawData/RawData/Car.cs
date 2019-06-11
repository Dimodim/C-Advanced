using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    class Car
    {
        public string Model;
        public Tire[]Tires;
        public Engine SpeedAndPower;
        public Cargo CargoWeightAndType;


        public Car(Tire[]tires,Engine speedAndPower,Cargo cargoWeightAndType,string model)
        {
            Model = model;
            this.Tires = tires;
            this.SpeedAndPower = speedAndPower;
            this.CargoWeightAndType = cargoWeightAndType;
        }

    }
}
