using System;

namespace DesignPatterns.Creational.Singleton
{
    public class Client
    {
        public static void Execute()
        {
            Console.WriteLine("test");
            Console.ReadKey();

            var service1 = Context.Instance.GetSettings("1");
            Console.WriteLine($"Service: {service1}");

            var service2 = Context.Instance.GetSettings("2");
            Console.WriteLine($"Service: {service2}");

            Context.Instance.SetSettings("2", "X");
            service2 = Context.Instance.GetSettings("2");
            Console.WriteLine($"Service: {service2}");
        }
    }
}
