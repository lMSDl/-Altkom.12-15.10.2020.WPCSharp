using System;
using System.Linq;

namespace DesignPatterns.Structural.Adapter.II
{
    public class Client
    {
        public static void Execute()
        {
            var service = new DbPeopleService();

            var adapter = new DbPeopleServiceAdapter(service);

            adapter.Get().ToList().ForEach(ToString);

        }

        public static void ToString(IPerson person)
        {
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
        }
    }
}
