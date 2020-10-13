using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Builder
{
    public class VehicleBuilderFacade : VehicleBuilderBase
    {
        public VehicleBuilderFacade(Vehicle vehicle) : base(vehicle)
        {
        }

        public VehicleBuilder Components => new VehicleBuilder(Vehicle);
        public VehicleManufacturingInfoBuilder Manufacturing => new VehicleManufacturingInfoBuilder(Vehicle);
    }
}
