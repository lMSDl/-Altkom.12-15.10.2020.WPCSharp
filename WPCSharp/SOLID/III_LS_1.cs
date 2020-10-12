using System;

namespace SOLID.III_LS_1
{
    internal abstract class Vehicle
    {
        public string Name { get; set; }
        public abstract void Move();
    }

    internal class Airplain : Vehicle
    {
        public void Fly()
        {
            Console.WriteLine("LECĘ!");
        }

        public override void Move()
        {
            Fly();
        }
    }

    internal class Car : Vehicle
    {
        public void Drive()
        {
            Console.WriteLine("Jadę!");
        }

        public override void Move()
        {
            Drive();
        }
    }
}
