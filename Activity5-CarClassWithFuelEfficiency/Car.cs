using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity5_CarClassWithFuelEfficiency
{
    internal class Car
    {
        public double FuelCapacity { get; set; }
        public double FuelEfficiency { get; set; } 

        public double MaxDistance 
        {
            get { return FuelCapacity * FuelEfficiency; } 
        }

        

        public Car(double fuelCapacity, double fuelEfficiency)
        {
            FuelCapacity = fuelCapacity;
            FuelEfficiency = fuelEfficiency;
        }
    }
}
