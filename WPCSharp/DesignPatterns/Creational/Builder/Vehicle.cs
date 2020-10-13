using Newtonsoft.Json;
using System;

namespace DesignPatterns.Creational.Builder
{
    public class Vehicle
    {
        private Vehicle()
        {

        }

        public static VehicleBuilderFacade GetBuilder() => new VehicleBuilderFacade(new Vehicle());

        /*public Vehicle()
        {

        }
        public Vehicle(int wheels, int seats)
        {
            Wheels = wheels;
            Seats = seats;
        }
        public Vehicle(int wheels, int seats, int doors) : this(wheels, seats)
        {
            Doors = doors;
        }
        public Vehicle(int wheels, int seats, int? trunkCapacity) : this(wheels, seats)
        {
            TrunkCapacity = trunkCapacity;
        }
        //public Vehicle(int wheels, int seats, int? enginePower) : this(wheels, seats)
        //{
        //    EnginePower = enginePower;
        //}
        public Vehicle(int wheels, int? enginePower, int seats) : this(wheels, seats)
        {
            EnginePower = enginePower;
        }
        public Vehicle(int wheels, int seats, int doors, int? trunkCapacity, int? enginePower) : this(wheels, seats, doors)
        {
            TrunkCapacity = trunkCapacity;
            EnginePower = enginePower;
        }*/

        public int Wheels { get; set; }
        public int Seats { get; set; }
        public int Doors { get; set; }
        public int? TrunkCapacity { get; set; }
        public int? EnginePower { get; set; }

        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public DateTime ProductionDate { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }

    }
}
