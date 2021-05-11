using System;

namespace VehicleAccessors
{
    class Program
    {
        static void Main(string[] args)
        {
            Car newCar = new Car();
            Semi newCar2 = new Semi();
        }
    }

    public class Vehicle
    {
        protected string model;
        protected string make;
        protected string vinNumber;

        protected Vehicle() {

        }
    }

    public class Car : Vehicle
    {
        public Car() {

        }

    }

    public class Semi : Vehicle
    {
        public Semi() {

        }

    }
}
