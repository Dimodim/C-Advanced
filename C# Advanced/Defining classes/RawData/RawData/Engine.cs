using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Engine
    {
        private int power;
        private int speed;
        public Engine(int speed,int power)
        {
            this.power = power;
            this.speed = speed;
        }
        public int Power
        {
            get => this.power;
        }
        public int Speed
        {
            get => this.speed;
        }

    }
}
