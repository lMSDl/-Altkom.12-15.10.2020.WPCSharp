using System;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class Order
    {
        private readonly ICar _car;

        public Order(ICarFactory factory, string type, string segment)
        {
            switch(type)
            {
                case nameof(ISedan):
                    _car = factory.ManufactureSedan(segment);
                    break;
                case nameof(ISuv):
                    _car = factory.ManufactureSuv(segment);
                    break;
                default:

                    break;
            }
        }

        public string ManufacturedCarName()
        {
            return _car.Name();
        }
    }
}
