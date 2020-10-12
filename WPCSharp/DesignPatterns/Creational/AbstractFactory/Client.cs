using System;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class Client
    {
        public static void Execute()
        {
            Order order;

            order = new Order(new HondaFactory(), nameof(ISedan), "compact");
            Console.WriteLine(order.ManufacturedCarName());


            order = new Order(new HondaFactory(), nameof(ISuv), "compact");
            Console.WriteLine(order.ManufacturedCarName());


            order = new Order(new ToyotaFactory(), nameof(ISuv), "full");
            Console.WriteLine(order.ManufacturedCarName());

        }
    }
}
