using System;

namespace DesignPatterns.Creational.FactoryMethod
{
    internal class ElevatorUp : IElevatorOperation
    {
        public void Operate(int floor)
        {
            Console.WriteLine($"Winda zatrzyma się na piętrze {floor} podczas jazdy do góry");
        }
    }
}
