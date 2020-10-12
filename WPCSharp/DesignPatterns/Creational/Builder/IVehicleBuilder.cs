using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Builder
{
    public interface IVehicleBuilder
    {
        IVehicleBuilder SetWheels(int value);
        IVehicleBuilder SetSeats(int value);
        IVehicleBuilder SetDoors(int value);
        IVehicleBuilder SetTrunkCapacity(int value);
        IVehicleBuilder SetEnginePower(int value);

        object Build();
    }
}
