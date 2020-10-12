using System;

namespace DesignPatterns.Creational.FactoryMethod
{
    internal class ElevatorGoTo : IElevatorOperation
    {
        public void Operate(int floor)
        {
            Console.WriteLine($"Rusza na piętro {floor}");
        }
    }
}
