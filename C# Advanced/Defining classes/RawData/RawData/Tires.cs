using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    class Tire
    {
        public double tirePressure;
        public int tireAge;

        
        public Tire(int tireAge , double tirePressure)
        {
            this.tireAge = tireAge;
            this.tirePressure = tirePressure;
        }
        public double TirePressure
        {
            get { return this.tirePressure; }
            
        }
        public int TireAge
        {
            get => this.tireAge;
        }
        


    }
}
