using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Builder
{
    public class VehicleManufacturingInfoBuilder : VehicleBuilderFacade
    {
        public VehicleManufacturingInfoBuilder(Vehicle vehicle) : base(vehicle)
        {
        }

        public VehicleManufacturingInfoBuilder SetManufacturer(string value)
        {
            Vehicle.Manufacturer = value;
            return this;
        }
        public VehicleManufacturingInfoBuilder SetModel(string value)
        {
            Vehicle.Model = value;
            return this;
        }
        public VehicleManufacturingInfoBuilder SetProductionDate(DateTime value)
        {
            Vehicle.ProductionDate = value;
            return this;
        }

    }
}
