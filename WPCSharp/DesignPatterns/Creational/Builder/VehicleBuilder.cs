namespace DesignPatterns.Creational.Builder
{
    public class VehicleBuilder : IVehicleBuilder
    {
        private Vehicle _vehicle;

        //public VehicleBuilder() : this(new Vehicle())
        //{
        //}

        public VehicleBuilder(Vehicle vehicle)
        {
            _vehicle = vehicle;
        }

        public IVehicleBuilder SetDoors(int value)
        {
            _vehicle.Doors = value;
            return this;
        }

        public IVehicleBuilder SetEnginePower(int value)
        {
            _vehicle.EnginePower = value;
            return this;
        }

        public IVehicleBuilder SetSeats(int value)
        {
            _vehicle.Seats = value;
            return this;
        }

        public IVehicleBuilder SetTrunkCapacity(int value)
        {
            _vehicle.TrunkCapacity = value;
            return this;
        }

        public IVehicleBuilder SetWheels(int value)
        {
            _vehicle.Wheels = value;
            return this;
        }

        public Vehicle Build()
        {
            return _vehicle;
        }

        object IVehicleBuilder.Build()
        {
            return Build();
        }
    }
}
