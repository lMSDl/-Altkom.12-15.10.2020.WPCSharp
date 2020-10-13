using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Builder
{
    public abstract class VehicleBuilderBase
    {
        protected Vehicle Vehicle { get; }

        public VehicleBuilderBase(Vehicle vehicle)
        {
            Vehicle = vehicle;
        }

        public Vehicle Build()
        {
            return Vehicle;
        }
    }
}
