using System;

namespace DesignPatterns.Structural.Composite
{
    public class Product : ProductBase, ICloneable
    {
        public float Price { get; }
        public Product(string name, float price) : base(name)
        {
            Price = price;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public override float GetPrice()
        {
            return Price;
        }
    }
}
