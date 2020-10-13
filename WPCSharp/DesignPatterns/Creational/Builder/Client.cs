using System;

namespace DesignPatterns.Creational.Builder
{
    public class Client
    {
        public static void Execute()
        {
            var vehicle = Vehicle.GetBuilder()
                .Components
                    .SetWheels(4)
                    .SetSeats(5)
                    .SetDoors(4)
                    .SetTrunkCapacity(500)
                    .SetEnginePower(100)
                .Manufacturing
                    .SetModel("X012")
                    .SetManufacturer("Altkom")
                    .SetProductionDate(DateTime.Now)
            .Build();


            Console.WriteLine(vehicle.ToString());
        }
    }
}
