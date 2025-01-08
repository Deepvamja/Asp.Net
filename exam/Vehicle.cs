using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    internal class Vehicle
    {
        public string Model;
        public string brand;
        public float speed;


        public vehic(string model, string brand, float speed)
        {
            this.Model = model;
            this.brand = brand;
            this.speed = speed;
        }

    }


    class Car: Vehicle
    {
        public int fueltype;
        public int Wheeltype;

    }
    class Bike : Vehicle
    {
        public int fueltype;
        public int Wheeltype;

    }

    public void DisplayDetails()
        {

        }
}
