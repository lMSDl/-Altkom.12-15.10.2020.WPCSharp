using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Structural.Flyweight
{
    public class CarFlyweightFactory
    {
        private readonly Dictionary<string, ICarFlyweight> _flyweights;

        public CarFlyweightFactory(IEnumerable<ICarFlyweight> flyweights)
        {
            _flyweights = flyweights.ToDictionary(x => GenerateKey(x));
        }

        public string GenerateKey(ICarFlyweight carFlyweight)
        {
            var elements = new List<string>
            {
                carFlyweight.Manufacturer,
                carFlyweight.Model,
                carFlyweight.Color
            };

            return string.Join("_", elements);
        }

        public ICarFlyweight GetFlyweight(ICarFlyweight carFlyweight)
        {
            var key = GenerateKey(carFlyweight);

            if(_flyweights.ContainsKey(key))
            {
                Console.WriteLine($"{GetType().Name}: Używamy istniejącego elementu ({key})");
                return _flyweights[key];
            }

            Console.WriteLine($"{GetType().Name}: Tworzymy nowy element ({key})");
            _flyweights.Add(key, carFlyweight);
            return carFlyweight;
        }

        public void ListFlyweights()
        {
            Console.WriteLine($"{GetType().Name}: Posiadamy {_flyweights.Count} elementów:");
            _flyweights.ToList().ForEach(x => Console.WriteLine(x.Key));
        }
    }
}
