using System;

namespace DesignPatterns.Creational.Builder
{
    public class Client
    {
        public static void Execute()
        {
            var vehicle = Vehicle.GetBuilder()
            .SetWheels(4)
            .SetSeats(5)
            .SetDoors(4)
            .SetTrunkCapacity(500)
            .SetEnginePower(100)
            .Build();


            Console.WriteLine(vehicle.ToString());
        }
    }
}
