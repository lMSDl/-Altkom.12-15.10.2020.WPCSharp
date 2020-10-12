using System;

namespace DesignPatterns.Creational.FactoryMethod
{
    internal class ElevatorDown : IElevatorOperation
    {
        public void Operate(int floor)
        {
            Console.WriteLine($"Winda zatrzyma się na piętrze {floor} podczas jazdy w dół");
        }
    }
}
