using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    public class Car
    {
        public string model;
        public double fuelAmount;
        public double fuelConsumption;
        public double travelledDistance;

        
        public Car(string model,double fuelAmount,double fuelConsumption)
        {
            this.model = model;
            this.fuelAmount = fuelAmount;
            this.fuelConsumption = fuelConsumption;
            this.travelledDistance = 0;
        }
        
        public  void Drive(double kilometers)
        {

            if (this.fuelAmount < kilometers * this.fuelConsumption)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                this.fuelAmount -= kilometers * this.fuelConsumption;
                this.travelledDistance += kilometers;
            }
           
            
        }


        





    }
}
