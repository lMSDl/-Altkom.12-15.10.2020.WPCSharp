using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Builder
{
    public class VehicleInfoBuilder : IVehicleBuilder
    {
        public StringBuilder _stringBuilder = new StringBuilder();

        public VehicleInfoBuilder()
        {
            _stringBuilder.Append("Obiekt ma:");
        }

        object IVehicleBuilder.Build()
        {
            return Build();
        }

        public string Build()
        {

            return _stringBuilder.ToString().Remove(_stringBuilder.Length - 1);
        }

        public IVehicleBuilder SetDoors(int value)
        {
            _stringBuilder.Append($"{value} drzwi,");
            return this;
        }

        public IVehicleBuilder SetEnginePower(int value)
        {
            _stringBuilder.Append($"silnik o mocy {value} HP,");
            return this;
        }

        public IVehicleBuilder SetSeats(int value)
        {
            _stringBuilder.Append($"{value} siedzeń,");
            return this;
        }

        public IVehicleBuilder SetTrunkCapacity(int value)
        {
            _stringBuilder.Append($"{value}l pojemności bagażnika,");
            return this;
        }

        public IVehicleBuilder SetWheels(int value)
        {
            _stringBuilder.Append($"{value} kół,");
            return this;
        }
    }
}
